
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    TMP_Text text;
    int score = 0;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        Pickup.PointPickup += AddScore;
    }

    private void AddScore(int points)
    {
        score += points;
        text.text = "score: " + score;
    }
}
