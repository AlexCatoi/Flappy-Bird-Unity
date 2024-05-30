using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    public float Timer=0;
    public float heighOff=10;
    float randomizer;
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate)
            Timer += Time.deltaTime;
        else
        {
            Timer= 0;
            spawnPipe();
            spawnCoin();
        }
        
    }
    void spawnPipe()
    {
        float Low = transform.position.y - heighOff;
        float High = transform.position.y + heighOff;
        randomizer = Random.Range(Low, High);
        Instantiate(Pipe, new Vector3(transform.position.x, randomizer, 0), transform.rotation);
    }
    void spawnCoin() { 
        int num = Random.Range(0, 100);
        if (num % 2 == 0)
        {
            Instantiate(coin, new Vector3(transform.position.x, randomizer, 0), transform.rotation);
        }
    }
}
