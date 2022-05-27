using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour
{
    
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            gameManager.GetComponent<GameManager>().GameOver();
        }
    }
}
    