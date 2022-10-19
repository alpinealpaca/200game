using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    private Animator anim;

    public int damage = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Cleanup();
        }
    }

    private void Cleanup()
    {
        anim.SetTrigger("Shovel");
    }

    //cannot do while jumping/falling
    //detect breakable && damage it.


    //void OnTriggerEnter2D(Collider2D hitInfo)
    //{
      //  Enemy spacejunk = hitInfo.GetComponent<Breakable>();
        //if (spacejunk != null)
        //{
         //   spacejunk.TakeDamage(damage);
            
        //}
        
    //}


}
