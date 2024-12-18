using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text timeText;

    private float elapsedTime = 0f;

    void Update()
    {
        // Update waktu
        elapsedTime += Time.deltaTime;

        // Format waktu (menit:detik)
        string formattedTime = FormatTime(elapsedTime);

        //update score
        if (ScoreManager.Instance != null)
        {
            scoreText.text = "Score: " + ScoreManager.Instance.GetCurrentScore();
        }

        timeText.text = "Time: " + formattedTime;

    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60); // Konversi ke menit
        int seconds = Mathf.FloorToInt(time % 60); // Sisa detik
        return $"{minutes:00}:{seconds:00}"; // Format ke "MM:SS"
    }
}
