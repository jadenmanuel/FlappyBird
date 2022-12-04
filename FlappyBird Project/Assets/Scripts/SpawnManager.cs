using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;

    public Vector3 spawnPos;
    private float startDelay = 1;
    private float repeatRateObstacle = 13;
    private float repeatRateTree = 2;
    private int[] obstacles = new int[10];
    public List<GameObject> trees = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRateObstacle);
        InvokeRepeating("SpawnTrees", startDelay, repeatRateTree);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {

        float z = -15.08f;
        for (int i = 0; i < 5; i++)
        {
            float y = -1.666f + Random.Range(-3f, 3f);

            Vector3 spawnPos = new Vector3(2.753f, y, (z + 14 * i));
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }

    void SpawnTrees()
    {

        for (int i = 0; i < 5; i++)
        {
            int treeIndex = Random.Range(0, trees.Count);

            //[-25, -8] or [8, 25]
            float x = Random.Range(8.0f, 25.0f);
            if (Random.Range(0, 2) == 0)
            {
                x *= -1;
            }
            float y = -8.4f;
            float z = 100.0f;

            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(trees[treeIndex], spawnPos, trees[treeIndex].transform.rotation);
        }


    }
}
