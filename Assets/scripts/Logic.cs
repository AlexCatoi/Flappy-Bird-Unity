using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Logic : MonoBehaviour
{
    public int score=0;
    public int highscore;
    public int coins = 0;
    public TMP_Text scoreText;
    public TMP_Text coinsText;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]

    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    public void addScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        scoreText.text = "Score: "+ score.ToString();
    }
    public void addCoins(int coinsToAdd)
    {
        coins += coinsToAdd;
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true); 
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void highestScore()
    {
        if (score > highscore)
            PlayerPrefs.SetInt("Highscore", score);
    }
    public void Money()
    {
        PlayerPrefs.SetInt("Money",PlayerPrefs.GetInt("Money")+coins);
        PlayerPrefs.SetInt("MoneyToUse", PlayerPrefs.GetInt("MoneyToUse") + coins);
    }

}
