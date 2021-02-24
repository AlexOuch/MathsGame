using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text text;
    public GameObject canvasSuccess;
    public GameObject canvasFail;

    public Transform gameObject;
    public void Question()
    {
        canvasSuccess.transform.gameObject.SetActive(false);
        canvasFail.transform.gameObject.SetActive(false);
        gameObject.GetComponent<Question>().getQuestion();
    }

    public void Answer()
    {
        double answer = gameObject.GetComponent<Question>().getAnswer();
        print(answer.ToString(".00"));
        if (text.text == answer.ToString(".00"))
        {
            canvasSuccess.transform.gameObject.SetActive(true);

            print("correct!");
        }
        else
        {
            canvasFail.transform.gameObject.SetActive(true);
            print("fail :(");
        }

            
    }

}

