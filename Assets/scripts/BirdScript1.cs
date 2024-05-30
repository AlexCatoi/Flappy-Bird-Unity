using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript1 : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public Logic logical;
    public bool birdIsAlive = true;
    public float top,bottom;
    // Start is called before the first frame update
    void Start()
    {
        logical = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
       // PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)==true && birdIsAlive==true)
            myRigidBody.velocity = Vector2.up * flapStrength;
        if(Input.GetKeyDown(KeyCode.DownArrow) == true && birdIsAlive == true)
            myRigidBody.velocity = Vector2.down * flapStrength;
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true && birdIsAlive == true)
            myRigidBody.velocity = Vector2.down * (2*flapStrength);
        if (Input.GetKeyDown(KeyCode.RightArrow) == true && birdIsAlive == true)
            myRigidBody.velocity = Vector2.up * (2*flapStrength);
        if (transform.position.y > top || transform.position.y < bottom)
        {
            logical.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logical.gameOver();
        birdIsAlive = false;
        logical.highestScore();
        logical.Money();
    }
    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.tag=="Mycoin" && birdIsAlive==true)
        {
            logical.addCoins(1);
            Destroy(coin.gameObject);
        }
    }
}
