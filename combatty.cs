using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatty : MonoBehaviour
{
    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask titan;

    public int attackDamage = 100;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

    }
    void Attack()
    {
        Collider[] hitEnemy =  Physics.OverlapSphere(attackpoint.position, attackRange, titan);

        foreach(Collider enemy in hitEnemy)
        {
            enemy.GetComponent<titans>().TakeDamage(100);
        }

    }
    
    
}
