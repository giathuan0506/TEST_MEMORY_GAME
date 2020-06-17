using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventButton : MonoBehaviour {

    public Text txtResult;

    public void _Clear()
    {
        txtResult.text = "";
    }
}
