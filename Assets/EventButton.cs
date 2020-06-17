using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventButton : MonoBehaviour {

    public Text txtResult;
    public GameObject btnCorrect;
    public GameObject btnFail;


    public void _Clear()
    {
        txtResult.text = "";
    }

    public void _Submit()
    {
        int num = int.Parse(txtResult.text);

        GameManager gameMag = FindObjectOfType<GameManager>();

        if (gameMag.CheckNumberInList(num))
        {
            
        }
        else
        {
            btnFail.SetActive(true);
            gameMag.GameOver();
        }

        if (gameMag.IsEmptyList())
        {
            btnCorrect.SetActive(true);
        }
        txtResult.text = "";
    }
    public void _Correct()
    {
        btnCorrect.SetActive(false);
        GameManager gameMag = FindObjectOfType<GameManager>();
        gameMag.NewTurn();
    }

    public void _Fail()
    {
        Application.LoadLevel("menu");
    }

    public void _Play()
    {
        Application.LoadLevel("gameplay");
    }

    public void _Quit()
    {
        Application.Quit();
    }
}
