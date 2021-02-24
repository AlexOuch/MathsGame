using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

    public Text side;
    public Text angle;
    public Text variable;
    public Text choice1;
    public Text choice2;
    public Text choice3;

    public Transform sidePos1;
    public Transform sidePos2;
    public Transform sidePos3;

    public double answer;

    void Update()
    {

    }

    public void getQuestion()
    {
        int num = Random.Range(1, 4);
        print(num);
        if (num == 1)
        {
            side.transform.position = sidePos1.transform.position;
            variable.transform.position = sidePos2.transform.position;
            tanQuestion();
        }

        else if (num == 2)
        {
            side.transform.position = sidePos3.transform.position;
            variable.transform.position = sidePos2.transform.position;
            sinQuestion();

        }
        else if (num == 3)
        {
            side.transform.position = sidePos3.transform.position;
            variable.transform.position = sidePos1.transform.position;
            cosQuestion();
        }
    }

    void tanQuestion()
    {
        int num = Random.Range(10, 100);
        int numangle = Random.Range(1, 90);
        double realAnswer = num * Mathf.Tan(numangle * Mathf.Deg2Rad);
        double fakeAnswer1 = realAnswer * RandomMultiplier();
        double fakeAnswer2 = realAnswer * RandomMultiplier();

        side.text = num.ToString();
        angle.text = numangle.ToString() + "°";
        MultipleChoice(realAnswer, fakeAnswer1, fakeAnswer2);
    }

    void cosQuestion()
    {
        int num = Random.Range(10, 111);
        int numangle = Random.Range(1, 90);
        double realAnswer = num * Mathf.Cos(numangle * Mathf.Deg2Rad);
        double fakeAnswer1 = realAnswer * RandomMultiplier();
        double fakeAnswer2 = realAnswer * RandomMultiplier();

        side.text = num.ToString();
        angle.text = numangle.ToString() + "°";
        MultipleChoice(realAnswer, fakeAnswer1, fakeAnswer2);
    }

    void sinQuestion()
    {
        int num = Random.Range(10, 111);
        int numangle = Random.Range(1, 90);
        double realAnswer = num * Mathf.Sin(numangle * Mathf.Deg2Rad);
        double fakeAnswer1 = realAnswer * RandomMultiplier();
        double fakeAnswer2 = realAnswer * RandomMultiplier();

        side.text = num.ToString();
        angle.text = numangle.ToString() + "°";
        MultipleChoice(realAnswer, fakeAnswer1, fakeAnswer2);
    }

    double RandomMultiplier()
    {
        double num1 = Random.Range(90, 110);
        if(num1 == 100)
        {
            num1 = 110;
        }
        double multiplier = num1 / 100;
        return multiplier;
    }

    void MultipleChoice(double real, double fake1, double fake2)
    {
        int num = Random.Range(1, 6);
        if (num == 1)
        {
            choice1.text = real.ToString(".00");
            choice2.text = fake1.ToString(".00");
            choice3.text = fake2.ToString(".00");
        }
        else if (num == 2)
        {
            choice1.text = real.ToString(".00");
            choice2.text = fake2.ToString(".00");
            choice3.text = fake1.ToString(".00");
        }
        else if (num == 3)
        {
            choice1.text = fake1.ToString(".00");
            choice2.text = real.ToString(".00");
            choice3.text = fake2.ToString(".00");
        }
        else if (num == 4)
        {
            choice1.text = fake1.ToString(".00");
            choice2.text = fake2.ToString(".00");
            choice3.text = real.ToString(".00");
        }
        else if (num == 5)
        {
            choice1.text = fake2.ToString(".00");
            choice2.text = real.ToString(".00");
            choice3.text = fake1.ToString(".00");
        }
        else
        {
            choice1.text = fake2.ToString(".00");
            choice2.text = fake1.ToString(".00");
            choice3.text = real.ToString(".00");
        }

        answer = real;

    }

    public double getAnswer()
    {
        return answer;
    }



    
}
