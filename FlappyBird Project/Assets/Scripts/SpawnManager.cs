using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public PlayerController bird;
    public Vector3 spawnPos;
    private float startDelay = 1;
    private float repeatRateObstacle = 11;
    private float repeatRateTree = 2;
    private int[] obstacles = new int[10];
    public List<GameObject> trees = new List<GameObject>();
    public List<GameObject> powerups = new List<GameObject>();

    public void StartGame()
    {



        Debug.Log(bird.speed);
        switch (bird.speed)
        {
            case 7:
                repeatRateObstacle = 8;
                break;

            case 9:
                repeatRateObstacle = 6;
                break;
        }

        InvokeRepeating("SpawnObstacle", startDelay, repeatRateObstacle);
        InvokeRepeating("SpawnTrees", startDelay, repeatRateTree);

        //InvokeRepeating("SpawnObstacle", startDelay, repeatRateObstacle);
        //InvokeRepeating("SpawnTrees", startDelay, repeatRateTree);
    }
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObstacle", startDelay, repeatRateObstacle);
        //InvokeRepeating("SpawnTrees", startDelay, repeatRateTree);
        bird = GameObject.Find("FlappyBird3D").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPowerup(Vector3 pos)
    {
        Debug.Log("Powerup spawned");
        int randomIndex = Random.Range(0, powerups.Count);
        Instantiate(powerups[randomIndex], pos, powerups[randomIndex].transform.rotation);
    }

    Vector3 generateObstacleCoords(int i)
    {

        float z = 15f;
        float y = -1.666f + Random.Range(-3f, 3f);

        Vector3 spawnPos = new Vector3(2.753f, y, (z + 14 * i));
        return spawnPos;
    }
    void SpawnObstacle()
    {

        //float z = 15f;
        for (int i = 0; i < 4; i++)
        {
            //float y = -1.666f + Random.Range(-3f, 3f);

            Vector3 spawnPos = generateObstacleCoords(i);

            //Let's see if we will spawn in a powerup
            int randomNum = Random.Range(0, 10);
            if (randomNum <= 3)
            {
                Vector3 powerupPos = new Vector3(0, -1.666f + Random.Range(-2f, 2f), (spawnPos.z + 10));
                SpawnPowerup(powerupPos);

            }
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }


    Vector3 generateTreeCoords()
    {
        float x = Random.Range(8.0f, 25.0f);
        if (Random.Range(0, 2) == 0)
        {
            x *= -1;
        }
        float y = -8.4f;
        float z = 100.0f;

        return new Vector3(x, y, z);
    }
    void SpawnTrees()
    {

        for (int i = 0; i < 5; i++)
        {
            int treeIndex = Random.Range(0, trees.Count);

            //[-25, -8] or [8, 25]
            //float x = Random.Range(8.0f, 25.0f);
            //if (Random.Range(0, 2) == 0)
            //{
                //x *= -1;
           // }
            //float y = -8.4f;
            //float z = 100.0f;

            Vector3 spawnPos = generateTreeCoords();
            Instantiate(trees[treeIndex], spawnPos, trees[treeIndex].transform.rotation);
        }


    }
}
