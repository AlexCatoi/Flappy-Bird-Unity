using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnItem : MonoBehaviour
{
    [SerializeField]
    public GameObject Item;
    private Sprite img;
    private TMP_Text tx;
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Item, transform, true);
            Debug.Log(i);
            if (i == 0)
            {
                img = Resources.Load<Sprite>("sprites/beldum");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "     250$";
            }
            if (i == 1)
            {
                img = Resources.Load<Sprite>("sprites/dusk");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "     500$";
            }
            if (i == 2)
            {
                img = Resources.Load<Sprite>("sprites/marill");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "     750$";
            }
            if (i == 3)
            {
                img = Resources.Load<Sprite>("sprites/lugia");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    1000$";
            }
            if (i == 4)
            {
                img = Resources.Load<Sprite>("sprites/pawmo");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    1250$";
            }
            if (i == 5)
            {
                img = Resources.Load<Sprite>("sprites/marill");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    1500$";
            }
            if (i == 6)
            {
                img = Resources.Load<Sprite>("sprites/spirit");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    1750$";
            }
            if (i == 7)
            {
                img = Resources.Load<Sprite>("sprites/starly");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    2000$";
            }
            if (i == 8)
            {
                img = Resources.Load<Sprite>("sprites/charizard");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "    2250$";
            }
            if (i == 9)
            {
                img = Resources.Load<Sprite>("sprites/rookidee");
                Item.transform.GetChild(0).GetComponent<Image>().sprite = img;
                Item.transform.GetChild(2).GetComponent<TMP_Text>().text = "     150$";
            }
        }
    }


}
