using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;

    public Vector3 spawnPos;
    private float startDelay = 3;
    private float repeatRate = 10;
    private int[] obstacles = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {

        float z = -9.47113f;
        for (int i = 0; i < 5; i++)
        {
            float y = 3.77916f + Random.Range(-3f, 3f);

            Vector3 spawnPos = new Vector3(13.42038f, y, (z + 7 * i));
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }
}
