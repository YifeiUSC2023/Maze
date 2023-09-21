using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 



public class Player : MonoBehaviour
{
    public string victorySceneName = "WinScene"; // "WinScene"
    private bool hasWon = false;
    private void Update()
    {
        if (!hasWon)
        {
            // Get x,y position
            float playerX = transform.position.x;
            float playerY = transform.position.y;

            // check if player reach the exit
            if (playerX >= -9.5f && playerX <= -7.8f && playerY >= 2.5f && playerY <= 3.0f)
            {
                hasWon = true;
                ShowVictoryPage();
            }
        }
    }

    private void ShowVictoryPage()
    {
        // activate the winning page
        SceneManager.LoadScene(victorySceneName);
    }
}
