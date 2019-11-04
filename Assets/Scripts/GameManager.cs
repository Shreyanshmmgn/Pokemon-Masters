using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void gameOver() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    public void changeScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    public void exit() => Application.Quit();
}

