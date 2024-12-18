using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton untuk akses global

    private int _currentScore;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Fungsi menambah skor
    public void AddScore(int scoreToAdd)
    {
        _currentScore += scoreToAdd;
        Debug.Log("Score Updated: " + _currentScore);
    }

    // Fungsi mendapatkan skor saat ini
    public int GetCurrentScore()
    {
        return _currentScore;
    }
}
