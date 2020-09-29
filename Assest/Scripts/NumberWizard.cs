using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text guessText;

    int mid;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();
    }

    void StartGame()
    {
        
        mid = (max + min) / 2;
        guessText.text = mid.ToString();
        max++;
    }


    // Update is called once per frame

    public void onPressHigher()
    {
        min = mid;
        nextGuess();
        EventSystem.current.SetSelectedGameObject(null);

    }

    public void onPressLower()
    {
        max = mid;
        nextGuess();
        EventSystem.current.SetSelectedGameObject(null);
    }

    void nextGuess()
    {
        mid = (max + min) / 2;
        guessText.text = mid.ToString();
    }

    
}
