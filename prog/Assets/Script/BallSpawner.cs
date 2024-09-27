using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    public GameObject ball;
    public float elapsedTime;
    public Material BallMaterial;
    
    // Start is called before the first frame update

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateBall(RandColor(), RandPos());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= 1)
        {
            elapsedTime = 0;
            CreateBall(RandColor(),RandPos());
        }
    }
    private void CreateBall(Color c , Vector3 Pos)
    {
        GameObject CurrentBall = Instantiate(ball, Pos, Quaternion.identity);
        BallMaterial = CurrentBall.GetComponent<MeshRenderer>().material;
        if(elapsedTime >= 1)
        {
            Destroy(CurrentBall);
        }

        if (BallMaterial.shader.name == "Universal Render Pipeline/Lit")
        {
            BallMaterial.SetColor("_BaseColor", c);
        }
    }
    private Color RandColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }
    private Vector3 RandPos()
    {
        float x = Random.Range(-8.75f, 8.75f);
        float y = Random.Range(-5.75f, 5.75f);
        float z = Random.Range(-4f, 4f);
        return new Vector3(x, y, z);
    }
}
