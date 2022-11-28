using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody RB;
    //SerializeField]
    [Range(1, 50)]
    public float jumpForce;
    //[SerializeField]
    [Range(1.0f, 5.0f)]
    public float gravityForce;
    private Vector3 direction;
    private Boolean delay;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        jumpForce = 40;
        gravityForce = 2;
        Physics.gravity *= gravityForce;
        delay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!delay) {
                direction = Vector3.up * jumpForce;
                direction += Time.deltaTime * Physics.gravity;
                transform.position += direction;
                //RB.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
                StartCoroutine(MovementControl());
            }

        }
   
        //StartCoroutine(MovementControl());
        
    }
    private void FixedUpdate()
    {
        
    }
    IEnumerator MovementControl() {
        

            delay = true;
            yield return new WaitForSeconds(0.5f);
            delay = false;
        
    }


}
