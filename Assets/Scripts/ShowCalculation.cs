using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowCalculation : MonoBehaviour
{
    public static string Math = "";
    public static string answer = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = Math + "=" + answer;
    }
}
