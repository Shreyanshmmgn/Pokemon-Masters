using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScreen : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("pokeballCount",0);
        Debug.Log(PlayerPrefs.GetInt("pokeballCount"));
    }
}
