using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered radar");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited radar");
    }

}
