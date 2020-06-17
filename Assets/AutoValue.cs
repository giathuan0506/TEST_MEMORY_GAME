using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoValue : MonoBehaviour {

    public int value;
    public Text txtValue;

    private void Start()
    {
        Auto(0, 100);
    }

    public void Auto(int min, int max)
    {
        value = Random.Range(min, max);
        txtValue.text = value.ToString();
    }
}
