using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public int bodiesCount;

    public TextMeshProGUI bodiesCountText;
    
    public void Update()
    {
        bodiesCountText.text = "" + bodiesCount;
    }



    public void HandleCollectible(int collectibleValue)
    {
        bodies += collectibleValue;
    }
}