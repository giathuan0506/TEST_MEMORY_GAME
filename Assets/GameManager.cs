using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject number;
    public GameObject mainPanel;
    public int turn;

    void Start()
    {
        GenerateNumber();
        StartCoroutine(DisplayMainPanel());
    }

    public void GenerateNumber()
    {
        for (int i = 0; i < turn; i++)
        {
            float x = Random.Range(-2f, 2f);
            float y = Random.Range(-4f, 4f);
            Vector3 newPosition = new Vector3(x, y);

            Instantiate(number, newPosition, Quaternion.identity);
        }
    }

    IEnumerator DisplayMainPanel()
    {
        yield return new WaitForSeconds(turn);

        mainPanel.SetActive(true);
    }
}
