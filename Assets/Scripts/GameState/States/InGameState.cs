using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InGameState : MonoBehaviour, IState
{
    [Space]
    [SerializeField]
    GameObject inGamePanel;

    public void Enter()
    {
        inGamePanel.SetActive(true);
        Debug.Log("In Game Entered!");
    }

    public void Exit()
    {
        inGamePanel.SetActive(false);
        Debug.Log("In Game Exit!");
    }
}
