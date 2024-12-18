using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Scoremanager : MonoBehaviour
{

    public static int score;

    public static int highscore;

    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        score = 0;

        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            text.text = "" + score;

            PlayerPrefs.SetInt("highscore", highscore);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}