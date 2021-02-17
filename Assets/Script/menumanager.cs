using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{


    public void CarregarCnfig()
    {
        SceneManager.LoadScene("configuracoes");
        
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene("menuPrincipal");

    }

    public void Jogar()
    {
        if (Configuration.Instance.ButtonNumber == 4)
        {
            SceneManager.LoadScene("opcao3Cores");
        }
        else if (Configuration.Instance.ButtonNumber == 3)
        {
            SceneManager.LoadScene("opcao4Cores");
        }
        else if (Configuration.Instance.ButtonNumber == 2)
        {
            SceneManager.LoadScene("opcao5Cores");
        }
        else if (Configuration.Instance.ButtonNumber == 1)
        {
            SceneManager.LoadScene("opcao6Cores");
        }
        else if (Configuration.Instance.ButtonNumber == 0)
        {
            SceneManager.LoadScene("opcao7Cores");
        }
        else
        {
            SceneManager.LoadScene("opcao4Cores");
        }
    }
    //[SerializeField]

    /*  void Update()
      {
          if (Input.GetKeyDown(KeyCode.Escape))
          {
              SceneManager.LoadScene("MenuPrincipal");
          }
      }

    public void TriggerMenuBehavior(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void onmauseDoen()
    {
        SceneManager.LoadScene("configuracoes");
    }

    public void FecharApp()
    {
        Application.Quit();
    }
    */
}
