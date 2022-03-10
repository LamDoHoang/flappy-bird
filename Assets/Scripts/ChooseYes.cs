using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseYes : MonoBehaviour
{
    public RandomMath randomMath;
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseScore.score++;
        
        randomMath = GameObject.FindObjectOfType(typeof(RandomMath)) as RandomMath;
        if (randomMath.rightOrWrong == false)
        {
            Debug.Log("The solution is false");
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Crash);
            gameManager = GameObject.FindObjectOfType(typeof(GameManager)) as GameManager;
            gameManager.GameOver();
        }
        randomMath.RandomMathFunction();
        Console.WriteLine("YES");
    }
}
