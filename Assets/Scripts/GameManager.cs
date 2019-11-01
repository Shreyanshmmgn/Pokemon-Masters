using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    // private Animator animator;
    // private GameObject clone;
    // public GameObject game_object;
    // public Transform transform1;
    // Start is called before the first frame update
    void Start()
    {
        // animator = GetComponent<Animator>();
        // box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // public void restart_position_for_pikachu()
    // {
    //     clone = Instantiate(game_object, transform1.transform.position, Quaternion.identity);

    //     clone.transform.position = transform1.transform.position;
    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void changeScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void exit()
    {
        Application.Quit();
    }
}

