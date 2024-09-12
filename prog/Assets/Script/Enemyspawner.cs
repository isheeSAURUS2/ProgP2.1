using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public List<GameObject> enemys;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") != null)
        {
            enemys.Add(GameObject.FindGameObjectWithTag("Enemy"));
            GameObject.FindGameObjectWithTag("Enemy").gameObject.tag = "ISADDED";
            
        }
        if (Input.GetKeyDown("w"))
        {
            for (int i = 0; i < 100; i++)
            {
                Instantiate(enemyPrefab);
            }
        }
        if (Input.GetKeyDown("q"))
        {
            for(int i = 0;i<enemys.Count;i++)
            {
                Destroy(enemys[i]);
            }
            enemys.Clear();
        }

    }

    IEnumerator spawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(enemyPrefab);
            }
        }
    }
}
