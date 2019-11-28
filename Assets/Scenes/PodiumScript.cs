using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PodiumScript : MonoBehaviour
{
    public GameObject ScoreText;
    public string place;
    void Start()
    {
        Text txt = ScoreText.GetComponent<Text>();
        if (PlayerPrefs.HasKey("Player"+place))
        {
            txt.text += "1." + PlayerPrefs.GetString("Player"+place);
        }
    }
}
