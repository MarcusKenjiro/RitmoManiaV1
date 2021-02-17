using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState
{
    SEQUENCIA, 
    RESPONDER, 
    NOVA, 
    ERRO
}

public class GameController : MonoBehaviour
{
    public GameState gameState;

    public Text rodadaTxt, qtdCoresTxt;

    public float speed;

    public Color[] cor;
    public Image[] botoes;
    public GameObject startButton;

    public List<int> coresSeq;
    public int idResposta, qtdCores = 3, rodada;

    private AudioSource fonteAudio;
    public AudioClip[] sons;
    public AudioClip[] notasPadrao, notasPiano, notasFlauta;
    public AudioClip somAplausos;
    public GameObject canonConfete1, canonConfete2;
    public GameObject confeteParticulas1, confeteParticulas2;

    public GameObject buttonRepetir;

    public bool verificar;


    // Start is called before the first frame update
    void Start()
    {
        fonteAudio = GetComponent<AudioSource>();
        SpeedSelect();
        qtdCores = Configuration.Instance.SequenceSize;
        SondSelect();
        buttonRepetir.SetActive(false);
        qtdCoresTxt.text = string.Format("Sequência: {0}", qtdCores + rodada);
    }

    void SondSelect()
    {
        int j;

        if (Configuration.Instance.ButtonNumber == 0)
        {
            j = 7;
        }
        else if (Configuration.Instance.ButtonNumber == 1)
        {
            j = 6;
        }
        else if (Configuration.Instance.ButtonNumber == 2)
        {
            j = 5;
        }
        else if (Configuration.Instance.ButtonNumber == 3)
        {
            j = 4;
        }
        else if (Configuration.Instance.ButtonNumber == 4)
        {
            j = 3;
        }
        else
        {
            j = 7;
        }

        if (Configuration.Instance.Sonds == 0)
        {
                for (int q = 0; q < j; q++)
                {
                    sons[q] = notasPiano[q];
                }
            }
            else if (Configuration.Instance.Sonds == 1)
            {
                for (int q = 0; q < j; q++)
                {
                    sons[q] = notasPadrao[q];
                }
            }
            else
            {
                for (int q = 0; q < j; q++)
                {

                    sons[q] = notasFlauta[q];
                }
            }
        
    }

    void SpeedSelect()
    {
        if(Configuration.Instance.Speed == 0)
        {
            speed = 0.5f;
        }else if(Configuration.Instance.Speed == 1)
        {
            speed = 1;
        }
        else
        {
            speed = 1.5f;
        }
    }
    /* Update is called once per frame
    void Update()
    {  
    }*/

    public void StartGame()
    {
        buttonRepetir.SetActive(false);
        foreach (Image img in botoes)
        {
            img.color = cor[0];
        }
        StartCoroutine ("Sequencia", qtdCores + rodada);

    }

    public void NovaRodada()
    {
        foreach (Image img in botoes)
        {
            img.color = cor[0];
        }

        coresSeq.Clear();

        startButton.SetActive(true);
        rodadaTxt.text = string.Format("Rodada: {0}", rodada + 1);
        qtdCoresTxt.text = string.Format("Sequência: {0}", qtdCores + rodada);
    }

    IEnumerator Sequencia(int qtd)
    {
        startButton.SetActive(false);

        for(int r = qtd; r>0; r--)
        {
            yield return new WaitForSeconds(speed);
            int i = Random.Range(0, botoes.Length);
            botoes[i].color = cor[1];
            fonteAudio.PlayOneShot(sons[i]);

            coresSeq.Add(i);

            yield return new WaitForSeconds(speed);
            botoes[i].color = cor[0];
        }

        gameState = GameState.RESPONDER;
        idResposta = 0;
        buttonRepetir.SetActive(true);
        
    }

    IEnumerator Responder(int idbotao)
    {
        //buttonRepetir.SetActive(false);

        botoes[idbotao].color = cor[1];
        
        if(coresSeq[idResposta] == idbotao)
        {
            print("correto");
            verificar = true;
            fonteAudio.PlayOneShot(sons[idbotao]);
        }
        else
        {
            print("errado");
            gameState = GameState.ERRO;
            verificar = false;
            StartCoroutine( "GameOver");
        }

        idResposta += 1;

        if(idResposta == coresSeq.Count)
        {
            gameState = GameState.NOVA;
            
            if (verificar == true)
            {
                rodada += 1;
                Instantiate(confeteParticulas1, canonConfete1.transform.position, canonConfete1.transform.rotation);
                Instantiate(confeteParticulas2, canonConfete2.transform.position, canonConfete2.transform.rotation);
                fonteAudio.PlayOneShot(somAplausos);
                buttonRepetir.SetActive(false);
            }


            yield return new WaitForSeconds(speed);
            NovaRodada();
        }

        yield return new WaitForSeconds(0.3f);
        botoes[idbotao].color = cor[0];
    }

    IEnumerator GameOver()
    {
        buttonRepetir.SetActive(false);
        if (rodada <= 0)
        {
            rodada = 0;
        }
        else
        {
            rodada--;
        }
        fonteAudio.PlayOneShot(sons[botoes.Length]);

        yield return new WaitForSeconds(1);
        for (int i = 3; i>= 0; i--)
        {
            foreach (Image img in botoes)
            {
                img.color = cor[1];
            }
            yield return new WaitForSeconds(0.3f);
            foreach (Image img in botoes)
            {
                img.color = cor[0];
            }
            yield return new WaitForSeconds(0.3f);
        }

        NovaRodada();
    }

    IEnumerator Repetir(int qtd)
    {
        startButton.SetActive(false);
        buttonRepetir.SetActive(false);

        for (int r = 0; r < qtd; r++)
        {
            yield return new WaitForSeconds(speed);
            int i = coresSeq[r];
            botoes[i].color = cor[1];
            fonteAudio.PlayOneShot(sons[i]);

            yield return new WaitForSeconds(speed);
            botoes[i].color = cor[0];
        }

        gameState = GameState.RESPONDER;
        idResposta = 0;
        buttonRepetir.SetActive(true);
    }

    public void RepetirFun()
    {
        StartCoroutine("Repetir", qtdCores + rodada);
    }
}