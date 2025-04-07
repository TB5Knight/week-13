//Taylor Burdgess, Charlie Garrido

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TASK 1: As the first task, have a "Score: " text on the screen and update it to show the current score value.

public class GameManager : MonoBehaviour
{
   //Score variable
   private int score = 0;
   private Text scoreText;

   void Start()
   {
    UpdateScoreText();
   }

   public void AddScore(int points)
   {
    score += points;
    UpdateScoreText;
   }

   void UpdateScoreText()
   {
    if(scoreText !=null)
    {
     scoreText.text = "Score: " + score; 
    }
   }


}


//TASK 2: As the second task, have a coin appear randomly on the screen. You can find a coin sprite in the assets. Have the coin stay on the screen for a couple of seconds and then destroy itself. If the player picks up the coin, they should earn "1" score. Alternatively, you can also have the coin move on the screen from one side to the other like the enemies.
public class Coin : MonoBehaviour
{
    public int coins;

    public GameObject coinPrefab;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //coins = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gameManager.ChangeScoreText(coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            
            gameManager.AddCoins(1);            
            Destroy(gameObject);
        }
    }

        
    
}
