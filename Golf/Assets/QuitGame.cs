using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public static void QuitGameButton()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
