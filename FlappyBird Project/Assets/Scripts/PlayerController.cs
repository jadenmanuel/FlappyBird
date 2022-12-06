using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    private Rigidbody RB;
    public AudioClip jumpSound;
    private AudioSource playerAudio;

    //SerializeField]
    [Range(1, 50)]
    public float jumpForce;
    //[SerializeField]
    [Range(1.0f, 5.0f)]
    public float gravityForce;
    private Vector3 direction;
    private Boolean delay;

    public int speed = 5;

    public void StartGame(int addedSpeed)
    {
        speed += addedSpeed * 2;

        
       /* RB = GetComponent<Rigidbody>();

        jumpForce = 6.5f;
        gravityForce = 1.19f;
        Physics.gravity *= gravityForce;
        delay = false;*/
    }
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        jumpForce = 6.5f;
        gravityForce = 1.19f;
        Physics.gravity *= gravityForce;
        delay = false;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!delay) {
                //direction = Vector3.up * jumpForce;
                //direction += Time.deltaTime * Physics.gravity;
                //transform.position += direction;
                //if (RB.velocity.y < 0)
                //{
                //    RB.AddForce(Vector3.up * jumpForce * RB.velocity.y * -1, ForceMode.VelocityChange);
                //}

                //RB.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
                RB.velocity = Vector3.up * jumpForce;
                StartCoroutine(MovementControl());
                playerAudio.PlayOneShot(jumpSound, 1.0f);
            }

        }
   
        //StartCoroutine(MovementControl());
        
    }
    private void FixedUpdate()
    {
        
    }
    IEnumerator MovementControl() {
        

            delay = true;
            yield return new WaitForSeconds(0.2f);
            delay = false;
        
    }


}
