using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hidenMenuScript : MonoBehaviour
{
    public Image hidenMenu;
    // public Image hidenMenuButton;
    public bool check = false;



    private void OnMouseDown()
    {
        if(check == false)
        {
            OpenMenu();
        }
        else
        {
            CloseMenu();
        }
    }

    private void OpenMenu()
    {
        hidenMenu.gameObject.SetActive(true);
        check = true;
        AutoCloseMenu();
    }

    private void CloseMenu()
    {
        hidenMenu.gameObject.SetActive(false);
        check = false;
    }

    IEnumerator AutoCloseMenu()
    {
        yield return new WaitForSeconds(1);
        CloseMenu();

    }
}
