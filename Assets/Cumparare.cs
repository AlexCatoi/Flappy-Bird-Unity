using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cumparare : MonoBehaviour
{
    public Button btn;
    public Text sold;
    
    

    public void Schimbare()
    {
        ColorBlock cb = btn.colors;
        cb.normalColor = Color.grey;
        cb.highlightedColor = Color.grey;
        cb.pressedColor = Color.grey;
        cb.selectedColor = Color.grey;
        btn.colors = cb;
        sold.text = "Sold";
        sold.color = Color.white;
    }  


}
