
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;

public class RegisterController : MonoBehaviour
{

    [SerializeField]
    private InputField resgisterUser = null;

    [SerializeField]
    private InputField resgisterEmail = null;

    //tava passWoard
    [SerializeField]
    private InputField resgisterPassWord = null;

   // [SerializeField]
    //private InputField resgisterType = null;



    public void FazerLogin()
    {
        //StartCoroutine(EviarRequisicao());
        StartCoroutine(Eviar());

    }

    IEnumerator EviarRequisicao()
    {
        string endPoint = "localhost:3333/api/v1";
        string username = resgisterUser.text;
        string email = resgisterEmail.text;
        string password = resgisterPassWord.text;
       // string type = resgisterType.text;

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("email", email);
        form.AddField("password", password);
       // form.AddField("type", type);

        UnityWebRequest w = UnityWebRequest.Post(endPoint + "/usuario", form);
        yield return w.SendWebRequest();

        if (w.isNetworkError || w.isHttpError)
        {
            Debug.Log(w.error);

        }
        else
        {
            //StartCoroutine(CarregaScene());
            Debug.Log("sucesso");
        }

    }

    IEnumerator CarregaScene()
    {
        SceneManager.LoadScene("Login");
        yield return 0;
    }

    IEnumerator Eviar()
    {
        string endPoint = "localhost:3333/api/v1";
        //string username = "kenji";
        //string email = resgisterEmail.text;
        //string password = resgisterPassWord.text;
        // string type = resgisterType.text;

        WWWForm form = new WWWForm();
        form.AddField("username", "kenji");
        form.AddField("email", "mvdrk4@gmail.com");
        form.AddField("password", "123");
        form.AddField("fullname", "kenjiro");
        form.AddField("institution", "UFPA");
        form.AddField("profession", "Cientista");

        UnityWebRequest w = UnityWebRequest.Post("https://unity-game-api.herokuapp.com/api/v1/usuario", form);
        yield return w.SendWebRequest();

        if (w.isNetworkError || w.isHttpError)
        {
            Debug.Log(w.error);

        }
        else
        {
            //StartCoroutine(CarregaScene());
            Debug.Log("sucesso");
        }

    }

}
