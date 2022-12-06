using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnCoordinate
{
    public static Vector3 generateObstacleCoords(int i)
    {

        float z = 15f;
        float y = -1.666f + Random.Range(-3f, 3f);

        Vector3 spawnPos = new Vector3(2.753f, y, (z + 14 * i));
        return spawnPos;
    }
}
