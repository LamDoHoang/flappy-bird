using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomMath : MonoBehaviour
{
    public string solution;
    public bool rightOrWrong;
    public int number1;
    public int number2;
    public string symbol;
    public int result;
    // Start is called before the first frame update
    public void Start()
    {
        RandomMathFunction();
    }

    // Update is called once per frame
    public void Update()
    {
        GetComponent<TMP_Text>().text = solution.ToString();
    }

    public void RandomMathFunction()
    {
        number1 = Random.Range(0, 10);
        number2 = Random.Range(0, 10);
        char[] operators = { '+', '-', '*', '/' };
        char op = operators[Random.Range(0, 3)];
        symbol = op.ToString();

        if (Random.value >= 0.5)
        {
            rightOrWrong = true;
        }
        else
        {
            rightOrWrong = false;
        }
        

        if (rightOrWrong)
        {
            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
        }
        else
        {
            /*switch (symbol)
            {
                case "+":
                    result = number1 + number2 + Random.RandomRange(1,10);
                    break;
                case "-":
                    result = number1 - number2 + Random.RandomRange(1, 10);
                    break;
                case "*":
                    result = number1 * number2 + Random.RandomRange(1, 10);
                    break;
                case "/":
                    result = number1 / number2 + Random.RandomRange(1, 10);
                    break;
            }*/
            result = Random.Range(1, 100);
        }

        solution = number1 + " " + symbol + " " + number2 + " = " + result;
    }
}
