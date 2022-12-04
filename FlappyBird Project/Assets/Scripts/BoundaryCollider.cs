using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoundaryCollider : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle")
        {
            gameOverText.gameObject.SetActive(true);

            Debug.Log("Over!");

            Time.timeScale = 0;
        }
        
    }
}
