using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStartClass : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Random.RandomRange(0.2f, 1f), Random.RandomRange(0.2f, 1f), 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
