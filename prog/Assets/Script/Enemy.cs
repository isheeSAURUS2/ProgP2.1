using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 velocity = new Vector3 (0f,0.5f,0f);
    public Rigidbody rb;


    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,4);
    }
}
