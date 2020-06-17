using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject number;
    public GameObject mainPanel;
    public int turn;
    public Text turnVal;

    private List<GameObject> lstNumber;

    void Start()
    {
        lstNumber = new List<GameObject>();
        NewTurn();
    }

    public void GenerateNumber()
    {
        for (int i = 0; i < turn; i++)
        {
            float x = Random.Range(-2f, 2f);
            float y = Random.Range(-4f, 4f);
            Vector3 newPosition = new Vector3(x, y);

            GameObject obj = Instantiate(number, newPosition, Quaternion.identity);

            lstNumber.Add(obj);
        }
    }

    IEnumerator DisplayMainPanel()
    {
        yield return new WaitForSeconds(turn);

        mainPanel.SetActive(true);
        HideNumbers();
    }

    void HideNumbers()
    {
        for (int i = 0; i < lstNumber.Count; i++)
        {
            lstNumber[i].SetActive(false);
        } 
    } 

    public bool CheckNumberInList(int num)
    {
        for (int i = 0; i < lstNumber.Count; i++)
        {
            if (num == lstNumber[i].GetComponent<AutoValue>().value)
            {
                Destroy(lstNumber[i]);
                lstNumber.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool IsEmptyList()
    {
        if (lstNumber.Count == 0)
        {
            mainPanel.SetActive(false);
            turn += 1;
            turnVal.text = turn.ToString();
        }
        return lstNumber.Count == 0;
    }

    public void NewTurn()
    {
        GenerateNumber();
        StartCoroutine(DisplayMainPanel());
    }

    public void GameOver()
    {
        mainPanel.SetActive(false);
    }
}
