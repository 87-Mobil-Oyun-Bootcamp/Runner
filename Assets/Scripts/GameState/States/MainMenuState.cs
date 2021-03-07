using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : MonoBehaviour, IState
{
    [Space]
    [SerializeField]
    GameObject mainMenuPanel;

    public void Enter()
    {
        mainMenuPanel.SetActive(true);
        Debug.Log("Main Menu Entered!");
    }

    public void Exit()
    {
        mainMenuPanel.SetActive(false);
        Debug.Log("Main Menu Exit!");
    }
}
