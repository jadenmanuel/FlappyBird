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
    public int scoreNum;
    public bool isImmune;


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

    public void SetImmune(int time)
    {
        isImmune = true;
        Invoke("RemoveImmunity", 5);
    }

    public void RemoveImmunity()
    {
        isImmune = false;
    }
    public void updateScore()
    {

        score.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle" && !isImmune)
        {

            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);

            Debug.Log("Over!");

            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Ground")
        {
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);

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
