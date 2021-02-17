using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSairScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("menuPrincipal");
    }
}
