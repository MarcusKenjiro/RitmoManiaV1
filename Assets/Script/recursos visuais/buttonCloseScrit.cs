using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class buttonCloseScrit : MonoBehaviour
{
    public GameObject panelAviso;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelAviso.gameObject.SetActive(true);

        }
        
    }

    private void OnMouseDown()
    {
        panelAviso.gameObject.SetActive(true);
      
    }

    public void CoseGame()
    {
        Application.Quit();
    }

    public void Cancel()
    {
        panelAviso.gameObject.SetActive(false);
    }
}
