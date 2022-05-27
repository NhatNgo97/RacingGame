using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }

    public void GameOver() {
        Time.timeScale = 0;
        gameoverText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restartgame(){
        SceneManager.LoadScene(0);
    }
    public void StartGame(){
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("GameStartPanel").SetActive(false);
        
    }
}
