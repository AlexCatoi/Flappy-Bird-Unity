using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShopItems : MonoBehaviour
{
    public TMP_Text suma;

    void Start()
    {
        suma.text= PlayerPrefs.GetInt("MoneyToUse").ToString();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }


}
