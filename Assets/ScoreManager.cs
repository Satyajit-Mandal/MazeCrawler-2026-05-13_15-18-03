using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}