using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    
    public PlayerController bird;
    private float treeSpeed = 10.0f;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.Find("FlappyBird3D").GetComponent<PlayerController>();
     
    }

   // public void StartGame(int addedSpeed)
   // {
   //     speed += addedSpeed;
   // }

    // Update is called once per frame
    void Update()
    {

        if (tag == "Obstacle")
        {
            transform.Translate(Vector3.back * Time.deltaTime * bird.speed);
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime * treeSpeed);
        }


    }
}
