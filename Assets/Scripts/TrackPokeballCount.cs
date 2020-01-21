using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPokeballCount : MonoBehaviour
{
    public int pokeballCount = 0;
    // public int pokeballCount;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        PlayerPrefs.SetInt("pokeballCountcount", 0);
    }
    public void getpokeballCount()
    {
        pokeballCount += 1;
        PlayerPrefs.SetInt("pokeballCount", pokeballCount);
        Debug.Log("pokeballCount Count -- " + pokeballCount);
        Debug.Log(PlayerPrefs.GetInt("pokeballCount"));
    }
}
