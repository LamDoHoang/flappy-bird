using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        addingScore.gameManager = gameManager;
        gameManager.closeCanvas();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Crash);
        gameManager.GameOver();
        
    }
}
