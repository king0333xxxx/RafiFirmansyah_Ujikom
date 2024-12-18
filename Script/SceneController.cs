using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("GamePlay");
        _panelGameOver.SetActive(false);
        Time.timeScale = 1;

    }
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
        _panelGameOver.SetActive(false);

        Time.timeScale = 1;

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
        _panelGameOver.SetActive(false);

        Time.timeScale = 1;

    }

   
}
