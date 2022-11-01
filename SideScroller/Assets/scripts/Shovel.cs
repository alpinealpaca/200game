using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shovel : MonoBehaviour
{
    private Animator anim;
    public int damage = 1;

    public Transform digPoint;
    public float digRange = 0.5f;
    public LayerMask enemyLayers;

    [SerializeField] private float digRate = 0.7f;
    private float nextDig;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextDig)
        {
            nextDig = Time.time + digRate;  //no more spamming
            Cleanup();
        }
    }

    private void Cleanup()
    {
        anim.SetTrigger("Shovel");

        //detect enemies in circle from the digPoint //stores colliders hit in array
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(digPoint.position, digRange, enemyLayers);

        //Cleaning damage
        foreach(Collider2D cleanable in hitEnemies)
        {
            Debug.Log("cleaned up " + cleanable.name);
            //enemy.GetComponent<Enemy>().TakeDamage(damage);
            cleanable.gameObject.GetComponent<Breakable>().HandleDamage(damage);

            
        }

    }

    //draw the circle visible in the editor
    void OnDrawGizmosSelected()
    {
        if (digPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(digPoint.position, digRange);
    }

    

}
