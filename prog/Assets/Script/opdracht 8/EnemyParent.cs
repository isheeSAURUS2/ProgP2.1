using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent: MonoBehaviour, IDamageable, IMoveable
{
    protected int enemyHealth;
    protected float speed;
    public virtual int EnemyHealth
    {
        get { return enemyHealth; }
        set { enemyHealth = 0; }
    }
    public virtual float Speed
    {
        get { return speed; }
        set { speed = 0; }
    }
    public void TakeDamage()
    {
       enemyHealth--;
    }
    public virtual void Move()
    {
        Vector3 velocity = Vector3.right * speed * Time.deltaTime;
        transform.position += velocity;
    }
    public void DieCheck()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
public interface IDamageable
{
    public int EnemyHealth { get; set; }
    public void DieCheck();
    public void TakeDamage();
}
public interface IMoveable
{
    public float Speed { get; set; }
    public void Move();
}
