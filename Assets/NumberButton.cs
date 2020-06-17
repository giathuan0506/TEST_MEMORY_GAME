using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberButton : MonoBehaviour {

    public Text txtResult;

	public void _ButtonClick()
    {
        txtResult.text = txtResult.text + gameObject.name;
    }
}
