using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    public GameObject ball;
    public float elapsedTime;
    public Material BallMaterial;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= 1)
        {
            elapsedTime = 0;
            CreateBall();
        }
    }
    private void CreateBall()
    {
        Instantiate(ball);
    }
}
