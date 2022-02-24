using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseScore.score++;
    }
}
