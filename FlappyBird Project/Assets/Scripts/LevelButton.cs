using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    private Button button;
    public PlayerController bird;
    SpawnManager spawn;
    public bool update;
    public GameObject titleSceen;
    //private GameObject managerBird;
    private GameObject managerSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
        button = GetComponent<Button>();
        
        Time.timeScale = 0;
        
        bird = GameObject.Find("FlappyBird3D").GetComponent<PlayerController>();
        spawn = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        button.onClick.AddListener(SetLevel);

        //managerSpawn = GameObject.Find("SpawnManager").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetLevel()
    {
        Debug.Log(gameObject.name + " was clicked");

        Time.timeScale = 1f;

        bird.StartGame();
        //Time.timeScale = 1f;

        spawn.StartGame();
        titleSceen.gameObject.SetActive(false);
    }
}
