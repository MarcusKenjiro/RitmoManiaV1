using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuAreaScript : MonoBehaviour
{
    public Image hidenMenu;
    

    private void OnMoOnMouseDown()
    {
        hidenMenu.gameObject.SetActive(false);
    }
}
