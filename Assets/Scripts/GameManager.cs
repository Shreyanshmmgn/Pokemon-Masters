using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool pokemon = false;
    public bool Ash = false;
    // [SerializeField] collectables[] collect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Ash = true;
        }
        else if (other.CompareTag("Pokemon") | other.CompareTag("Charizard"))
        {
            pokemon = true;
        }
    }
    private void Update()
    {
        if (Ash)
        {
            if (pokemon)
            {
                changeScene();

            }
        }
    }
    public void ChangeSceneToSelection()
    {
        SceneManager.LoadScene("SelectPokemon");
        // Debug.Log("For Testing Pokeball Count = "+ 3);
        // PlayerPrefs.SetInt("pokeballCount",3);
    }

    public void charizardGame()
    {
        SceneManager.LoadScene("lvlCharizard");

    }
    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // for (int i = 0; i < collect.Length; i++)
        // {
        //     collect[i].checkCollectableCollected = true;

        // }
    }
    public void changeScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    public void exit() => Application.Quit();
}

