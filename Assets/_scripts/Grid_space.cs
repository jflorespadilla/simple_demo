using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Grid_space : MonoBehaviour {
    private Game_controller gameController;
    public Button button;
    public Text buttonText;

    public void setGameControllerReference(Game_controller controller)
    {
        gameController = controller;
    }

    public void setSpace()
    {
        buttonText.text = gameController.getPlayerSide();
        button.interactable = false;
        gameController.endTurn();
    }

}
