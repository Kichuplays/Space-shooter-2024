using UnityEngine;
using TMPro;

public class Scoremanager : MonoBehaviour
{
    [SerializeField] private float scoreMultiplier = 1f;
    [SerializeField] private TMP_Text scoreText;

    public float score;

    private void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreText.text = "Time: " + score.ToString("#.00");
    }
}