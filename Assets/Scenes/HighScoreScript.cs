using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    // Récupère les meilleurs scores dans la mémoire et les affiche
    public GameObject ScoreText;
    void Start()
    {
        Text txt = ScoreText.GetComponent<Text>();
        txt.text = "Meilleur Score \n";
        if (PlayerPrefs.HasKey("Player1"))
        {
            txt.text += "1."+PlayerPrefs.GetString("Player1")+"\n\n";
        }
        if (PlayerPrefs.HasKey("Player2"))
        {
            txt.text += "2."+PlayerPrefs.GetString("Player2")+"\n";
        }
        if (PlayerPrefs.HasKey("Player3"))
        {
            txt.text += "3."+PlayerPrefs.GetString("Player3")+"\n";
        }
        if (PlayerPrefs.HasKey("Player4"))
        {
            txt.text += "4." + PlayerPrefs.GetString("Player4") + "\n";
        }
        if (PlayerPrefs.HasKey("Player5"))
        {
            txt.text += "5." + PlayerPrefs.GetString("Player5") + "\n";
        }
    }
}
