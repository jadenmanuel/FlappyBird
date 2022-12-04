using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    private float speed = 5.0f;
    private float treeSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (tag == "Obstacle")
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime * treeSpeed);
        }


    }
}
