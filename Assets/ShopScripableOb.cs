using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu]
public class ShopScripableOb : ScriptableObject
{
    public Character[] charactersDB;

   

    public Character GetCharacter(int index)
    {
        return charactersDB[index]; 
    }
}
