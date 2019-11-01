using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreScript : MonoBehaviour
{
    public static int scoreVale;
    private Text score;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score :-" + scoreVale;
    }
}
