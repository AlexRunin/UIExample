using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private int hexagonScore;
    [SerializeField] private TextMeshProUGUI hexagonScoreText;


    public void UpdateScore(int i)
    {
        switch (i)
        {
            case 0:
                score++;
                scoreText.text = score.ToString();
                break;
            case 1:
                hexagonScore++;
                hexagonScoreText.text = hexagonScore.ToString();
                break;
            default:
                Debug.LogError("Неправильный параметр в UodateScore");
                break;
        }


    }
}

