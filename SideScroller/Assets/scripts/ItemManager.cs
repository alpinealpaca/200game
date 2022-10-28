using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public int cleanCount;

    public TextMeshProUGUI cleanCountText;
    
    public void Update()
    {
        cleanCountText.text = "" + cleanCount;
    }



    public void HandleCollectible(int collectibleValue)
    {
        cleanCount += collectibleValue;
    }
}