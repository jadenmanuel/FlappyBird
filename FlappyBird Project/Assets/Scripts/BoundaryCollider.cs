using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoundaryCollider : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI score;
    private int scoreNum;


    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        updateScore();
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
