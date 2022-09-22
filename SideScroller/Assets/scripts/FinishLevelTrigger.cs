using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevelTrigger : MonoBehaviour
{
    public GameObject finishscreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.compareTag("Player"))
        {
            finishscreen.SetActive(true);
        }

    }
}
