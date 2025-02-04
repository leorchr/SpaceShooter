using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //fonctions pour lancer le jeu et le quitter
    public void StartGame()
    {
        SceneManager.LoadScene("Scenes/Rules");
        Debug.Log("Start Game");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Scenes/MainScene");
        Debug.Log("Restart Game");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}