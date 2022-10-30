using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;

    private void Start()
    {
        //gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Congratulations You Win! Shoot Count : " + player.ShootCount;
        }
    }

    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }
    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }
    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
