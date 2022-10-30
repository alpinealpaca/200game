using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    public Transform Nozzle;
    public GameObject LaserbulletPrefab;
    public float shootTime = 2f;


    
    void Update()
    {
        //if (Input.GetButtonDown("Fire2")) //testing
        //{
        //    Shoot();
        //}
    
        //Fire every few seconds
        shootTime -= Time.deltaTime;

        if (shootTime< 0)
        {
            Shoot();
            shootTime = 2f;
        }
    }

    void Shoot()
    {
        Instantiate(LaserbulletPrefab, Nozzle.position, Nozzle.rotation);
    }

    
}


