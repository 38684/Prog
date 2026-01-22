
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    int score = 0;
    TMP_Text text;

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
