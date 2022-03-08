using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingScore : MonoBehaviour
{   public static GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ShowCalculation.answer != PillarSpawning.realAnswer)
        {
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Crash);
            gameManager.GameOver();
            ShowCalculation.answer = "";
;        }
        else
        {
            IncreaseScore.score++;
        }  
    }


}
