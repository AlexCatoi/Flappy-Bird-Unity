using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class stats : MonoBehaviour
{
    public TMP_Text best;
    public TMP_Text total;
    // Start is called before the first frame update
    void Start()
    {
        best.text = "Best Score: " + PlayerPrefs.GetInt("Highscore").ToString();
        total.text = "Total Coins: " + PlayerPrefs.GetInt("Money").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene("menu");
    }
}
