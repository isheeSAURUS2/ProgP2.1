using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Elf : EnemyParent, IMoveable, IDamageable
{
    public override int EnemyHealth
    {
        get { return EnemyHealth = 10; }
        set { EnemyHealth = 10; }
    }
    public override float Speed
    {
        get { return Speed = 3; }
        set { Speed = 3; }
    }
    [SerializeField]float timer;
    bool isInvisible;
  
    void Update()
    {
        timer += Time.deltaTime;
        Move();
        DieCheck();
        if (timer >= 3)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            isInvisible = true;
            timer = 0;
        }
        if (isInvisible&&timer >= 0.5f)
        {
            gameObject.GetComponent <MeshRenderer>().enabled = true;
            isInvisible = false;
            timer = 0;
        }
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
