using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnTowerOnClick : MonoBehaviour
{
    public GameObject Tower;
    public float distance;
    private Vector3 WorldPosition;
    private Plane plane = new Plane(Vector3.up, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(plane.Raycast(ray, out distance))
        {
            WorldPosition = ray.GetPoint(distance);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Tower, WorldPosition/*new Vector3(Random.Range(4.5f, -4.5f), 0, Random.Range(4.5f, -4.5f))*/, Quaternion.identity);
        }
    }
}
