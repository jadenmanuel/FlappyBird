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

    enum Level
    {
        Easy,
        Medium,
        Hard
    }

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

    void StartGame(Level level)
    {

        Time.timeScale = 1f;
        bird.StartGame((int)level);
        spawn.StartGame();
        titleSceen.gameObject.SetActive(false);
    }
    void SetLevel()
    {

        switch (gameObject.name)
        {

            case "Easy":
                Invoke("StartGame(Level.Easy)", 2);
                //StartGame(Level.Easy);
                break;

            case "Medium":
                
                StartGame(Level.Medium);
           
                break;

            case "Hard":
                
                StartGame(Level.Hard);
                
                break;

        }
   

        

        
    }
}
