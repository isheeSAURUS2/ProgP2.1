using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Player : EnemyParent, IMoveable, IDamageable
{
    public override int EnemyHealth
    {
        get { return EnemyHealth = 30; }
        set { EnemyHealth = 30; }
    }
    public override float Speed
    {
        get { return Speed = 3; }
        set { Speed = 3; }
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
    public override void Move()
    {
        Vector3 velocity = Vector3.zero;
        transform.position += velocity * Speed * Time.deltaTime;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.z = Input.GetAxisRaw("Vertical");
    }
}
