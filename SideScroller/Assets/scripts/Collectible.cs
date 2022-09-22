using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int collectibleValue;
    public GameObject CollectedVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collecting bodies logic
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ItemManager>().HandleCollectible(collectibleValues);
        }
    }
    
    public IEnumerator collected()
    {
        this.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = null;
        Instantiate(collectedVFX, gameObject.transform.localPosition, Quaternion.identity;
        yield return new WaitForSeconds(0.01f);
        Destroy(gameObject);
    }
        
}

