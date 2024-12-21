using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent, IMoveable, IDamageable
{
    public override int EnemyHealth
    {
        get { return EnemyHealth = 20; }
        set { EnemyHealth = 20; }
    }
    public override float Speed
    {
        get { return Speed = 1.5f; }
        set { Speed = 1.5f; }
    }
    void Update()
    {
        Move();
        DieCheck();
    }
    private void OnCollisionEnter(Collision o)
    {
        if (o.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
            Destroy(o.gameObject);
        }
    }
}
