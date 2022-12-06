using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoundaryCollider : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public TextMeshProUGUI score;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    private int scoreNum;


    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        updateScore();
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void updateScore()
    {

        score.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle")
        {
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            playerAudio.PlayOneShot(crashSound, 1.0f);


            Debug.Log("Over!");

            Time.timeScale = 0;
        }
        if (other.gameObject.tag == "PointChecker")
        {
            scoreNum += 1;
            updateScore();
        }

    }
}
