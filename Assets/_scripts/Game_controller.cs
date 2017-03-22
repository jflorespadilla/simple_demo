using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game_controller : MonoBehaviour {
    private string playerSide;
    public Text[] buttonList;
    public GameObject gameOverPanel;
    public Text gameOverText;
    private int moveCount;

    public void setGameControllerReferenceOnButtons()
    {

        for(int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Grid_space>().setGameControllerReference(this);
        }
    }

    private void Awake()
    {
        gameOverPanel.SetActive(false);
        moveCount = 0;
        setGameControllerReferenceOnButtons();
        playerSide = "X";
    }

    public string getPlayerSide()
    {
        return playerSide;
    }

    public void changeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";
        moveCount++;
    }

    public void endTurn()
    {
        // Row 1
        if(buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
        {
            gameOver();
        }

        // Row 2
        if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
        {
            gameOver();
        }

        // Row 3
        if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
        {
            gameOver();
        }

        // Col 1
        if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
        {
            gameOver();
        }

        // Col 2
        if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
        {
            gameOver();
        }

        // Col 3
        if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
        {
            gameOver();
        }

        // Diagnal 1
        if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
        {
            gameOver();
        }

        // Diagnal 2
        if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        {
            gameOver();
        }

        // Draw condition
        if (moveCount >= 9)
        {
            setGameOverText("Game Over! Game ends in a draw!\nPlay Again?");
        }
        changeSides();
    }

    private void setGameOverText(string value)
    {
        gameOverText.text = value;
        gameOverPanel.SetActive(true);
    }

    private void gameOver()
    {
        for(int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = false;
        }
        setGameOverText("Game Over!" + playerSide + " Wins!\nPlay Again?");
    }

}

