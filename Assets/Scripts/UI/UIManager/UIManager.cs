using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Space]
    [SerializeField]
    MainMenuController mainMenuController;

    [Space]
    [SerializeField]
    PauseMenuController pauseMenuController;


    [Space]
    [SerializeField]
    InGamePanelController inGamePanelController;

    public System.Action OnClickStartButton;
    public System.Action OnClickContinueButton;

    public System.Action<int> OnLevelChanged;
    public System.Action<float> OnLevelProcessChanged;

    private void Awake()
    {
        mainMenuController.OnClickedStartButton += StartButtonClicked;
        pauseMenuController.OnClickedContinueButton += ContinueButtonClicked;

        OnLevelChanged += LevelChanged;
        OnLevelProcessChanged += LevelProcessChanged;
    }

    void StartButtonClicked()
    {
        OnClickStartButton?.Invoke();
    }

    void ContinueButtonClicked()
    {
        OnClickContinueButton?.Invoke();
    }

    void LevelChanged(int currentLevel)
    {
        inGamePanelController.UpdateLevel(currentLevel);
    }

    void LevelProcessChanged(float levelProcess)
    {
        inGamePanelController.UpdateLevelProcess(levelProcess);
    }
}
