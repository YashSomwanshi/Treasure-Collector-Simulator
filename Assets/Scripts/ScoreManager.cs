using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject winPanel;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(int points)
    {
        score += points;

        scoreText.text = "Score: " + score;

        if(score == 70)
        {
            winPanel.SetActive(true);
        }
    }
}