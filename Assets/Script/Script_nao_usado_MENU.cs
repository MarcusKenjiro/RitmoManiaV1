using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class Menu : MonoBehaviour { 

    public Button BotaoJogar, BotaoOpcoes, BotaoSair;
    /*
    [Space(20)]
    public Slider BarraVolume;
    public Toggle CaixaModoJanela;
    
    public Button BotaoVoltar, BotaoSalvarPref;
    [Space(20)]
    public Text textoVol;
    public string nomeCenaJogo = "CENA1";
    private string nomeDaCena;
    private float VOLUME;
    private int modoJanelaAtivo;
    private bool telaCheiaAtivada;
    private Resolution[] resolucoesSuportadas;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    void Start()
    {
        Opcoes(false);

        //

        //
        nomeDaCena = SceneManager.GetActiveScene().name;
        Cursor.visible = true;
        Time.timeScale = 1;
        //
        BarraVolume.minValue = 0;
        BarraVolume.maxValue = 1;

        //=============== SAVES===========//
        if (PlayerPrefs.HasKey("VOLUME"))
        {
            VOLUME = PlayerPrefs.GetFloat("VOLUME");
            BarraVolume.value = VOLUME;
        }
        else
        {
            PlayerPrefs.SetFloat("VOLUME", 1);
            BarraVolume.value = 1;
        }
        //=============MODO JANELA===========//
        if (PlayerPrefs.HasKey("modoJanela"))
        {
            modoJanelaAtivo = PlayerPrefs.GetInt("modoJanela");
            if (modoJanelaAtivo == 1) {
                Screen.fullScreen = false;
                CaixaModoJanela.isOn = true;
            }
            else {
                Screen.fullScreen = true;
                CaixaModoJanela.isOn = false;
            }
        }
        else
        {
            modoJanelaAtivo = 0;
            PlayerPrefs.SetInt("modoJanela", modoJanelaAtivo);
            CaixaModoJanela.isOn = false;
            Screen.fullScreen = true;
        }
        //========RESOLUCOES========//

        //=========QUALIDADES=========//

        //=========VOIDS DE CHECAGEM==========//

        void Opcoes(bool ativarOP)
        {
            BotaoJogar.gameObject.SetActive(!ativarOP);
            BotaoOpcoes.gameObject.SetActive(!ativarOP);
            BotaoSair.gameObject.SetActive(!ativarOP);
            //
            textoVol.gameObject.SetActive(ativarOP);
            BarraVolume.gameObject.SetActive(ativarOP);
            CaixaModoJanela.gameObject.SetActive(ativarOP);
            BotaoVoltar.gameObject.SetActive(ativarOP);
            BotaoSalvarPref.gameObject.SetActive(ativarOP);
        }
        //=========VOIDS DE SALVAMENTO==========//
        void SalvarPreferencias()
        {
            if (CaixaModoJanela.isOn == true)
            {
                modoJanelaAtivo = 1;
                telaCheiaAtivada = false;
            }
            else
            {
                modoJanelaAtivo = 0;
                telaCheiaAtivada = true;
            }
            PlayerPrefs.SetFloat("VOLUME", BarraVolume.value);

            PlayerPrefs.SetInt("modoJanela", modoJanelaAtivo);


            AplicarPreferencias();
        }
        void AplicarPreferencias()
        {
            VOLUME = PlayerPrefs.GetFloat("VOLUME");

        }
        //===========VOIDS NORMAIS=========//
        void Update()
        {
            if (SceneManager.GetActiveScene().name != nomeDaCena)
            {
                AudioListener.volume = VOLUME;
                Destroy(gameObject);
            }
        }
        void Jogar()
        {
            SceneManager.LoadScene(nomeCenaJogo);
        }
        void Sair()
        {
            Application.Quit();
        }
    }
}

//-------------------------------------------------------------------------------------------------------------------------------------------
public class Configuracao : MonoBehaviour
{
    public int vel, seque;
    public Color[] corFundo;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Salvar()
    {

    }

    public void Iniciar()
    {

    }
    */
}