using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Vars



    // Funcs

    public void PlayGame()
    {

        //Change to game menu
        SceneManager.LoadScene("Plaas");

    }//PlayGame


    public void ExitGame()
    {

        Application.Quit();
        Debug.Log("Quitting Game");

    }//ExitGame


}// MAIN MENU
