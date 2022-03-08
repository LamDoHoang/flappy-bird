using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawning : MonoBehaviour
{
    public static string realAnswer;
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pillar;
    public float height;
    System.Random random = new System.Random();
    private int num1 = 0;
    private int num2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        num1 = random.Next(-100, 100);
        num2 = random.Next(-100, 100);
        realAnswer = (num1 + num2).ToString();
        ShowCalculation.Math = num1.ToString() + "+" + num2.ToString();
        ShowCalculation.answer = "";
        GameObject newPillar = Instantiate(pillar);
        Destroy(newPillar, 13);
    }

    // Update is called once per frame
    void Update()
    {
        ShowCalculation.answer += Input.inputString;
        if (timer > maxTime)
        {
            num1 = random.Next(-100, 100);
            num2 = random.Next(-100, 100);
            realAnswer = (num1 + num2).ToString();
            ShowCalculation.Math = num1.ToString() + "+" + num2.ToString();
            GameObject newPillar = Instantiate(pillar);
            newPillar.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPillar, 13);
            ShowCalculation.answer = "";
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
