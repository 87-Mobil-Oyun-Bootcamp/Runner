using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : MonoBehaviour, IState
{
    [Space]
    [SerializeField]
    GameObject pauseMenuPanel;

    public void Enter()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Pause Menu Entered!");
    }

    public void Exit()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Pause Menu Exit!");
    }
}
