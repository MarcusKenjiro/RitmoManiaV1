using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public GameController gameController;

    void OnMouseDown()
    {
        gameController.StartGame();
    }
}
