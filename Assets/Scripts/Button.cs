using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject player;
    public Text text;
    public GameObject canvasSuccess;
    public GameObject canvasFail;

    public Transform mainCanvas; //main canvas

    void Start()
    {
        mainCanvas.GetComponent<Question>().getQuestion();
    }
    
    /*public void Question()
    {        
        mainCanvas.GetComponent<Question>().getQuestion();
    }
    */

    public void Answer()
    {
        
        double answer = mainCanvas.GetComponent<Question>().getAnswer();
        print(answer.ToString(".00"));
        if (text.text == answer.ToString(".00"))
        {
            canvasSuccess.transform.gameObject.SetActive(true);
            print("correct!");
            StartCoroutine(TwoSecondsSuccess());
                        
        }
        else
        {
            canvasFail.transform.gameObject.SetActive(true);
            print("fail :(");
            StartCoroutine(TwoSecondsFail());
        }

        //mainCanvas.gameObject.SetActive(false);
            
    }

    IEnumerator TwoSecondsSuccess()
    {
        yield return new WaitForSeconds(1f);
        canvasSuccess.transform.gameObject.SetActive(false);
        mainCanvas.GetComponent<Question>().getQuestion();
    }

    IEnumerator TwoSecondsFail()
    {
        yield return new WaitForSeconds(1f);
        canvasFail.transform.gameObject.SetActive(false);
        mainCanvas.GetComponent<Question>().getQuestion();
    }

    
}

