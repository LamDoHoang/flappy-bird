using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawning : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pillar;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(timer > maxTime)
        {
            GameObject newPillar = Instantiate(pillar);
            newPillar.transform.position = transform.position + new Vector3(0, 1, 0);//Random.Range(-height, height), 0);
            Destroy(newPillar, 13);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
