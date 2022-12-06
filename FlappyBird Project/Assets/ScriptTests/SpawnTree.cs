using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree
{
    public static Vector3 generateTreeCoords()
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
}
