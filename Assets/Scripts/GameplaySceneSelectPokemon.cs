using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameplaySceneSelectPokemon : MonoBehaviour
{
    public Text pokeball;
    [SerializeField] GameObject charizard;
    // [SerializeField] Image colorCharizard;
    int count, reqCount;

    void Start()
    {
        PlayerPrefs.SetInt("ReqpokeballCount", 3);
    }
    void Update()
    {
        count = PlayerPrefs.GetInt("ReqpokeballCount") - PlayerPrefs.GetInt("pokeballCount");
        Debug.Log("Required Pokebalkls to unlock charizard - " + count);
        pokeball.text = count.ToString();
        if (count == 0)
        {
            charizard.SetActive(true);
        }
    }
    

}
