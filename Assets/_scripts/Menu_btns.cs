using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu_btns : MonoBehaviour {

    // Loads into game board
    public void playBtn(string game)
    {
        SceneManager.LoadScene(game);
    }

    // Quits entire application
    public void exitBtn()
    {
        Application.Quit();
    } 

    // Reloads game board
    public void playAgainBtn(string game)
    {
        SceneManager.LoadScene(game);
    }

    // Quits to main menu
    public void quitBtn(string menu)
    {
        SceneManager.LoadScene(menu);
    }

}
