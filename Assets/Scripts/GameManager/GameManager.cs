using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    None = 0,
    MainMenu,
    InGame,
    Pause
}

public class GameManager : MonoBehaviour
{
    #region Managers

    [Space]
    [SerializeField]
    UIManager uiManager;

    [SerializeField]
    LevelManager levelManager;

    [SerializeField]
    InputManager inputManager;

    #endregion

    #region GameStates

    [Space]
    public List<State> gameStates = new List<State>();

    Dictionary<StateType, IState> gameStateDict = new Dictionary<StateType, IState>();

    public StateType CurrentGameState
    {
        get
        {
            return currentGameState;
        }

        set
        {
            if (currentGameState == value)
            {
                return;
            }

            if (currentGameState != StateType.None)
            {
                gameStateDict[currentGameState].Exit();
            }

            currentGameState = value;

            if (currentGameState != StateType.None)
            {
                gameStateDict[currentGameState].Enter();
            }
        }
    }

    StateType currentGameState = StateType.None;

    #endregion

    private void Awake()
    {
        FillGameStateDictionary();
        BindButtonClicks();

        CurrentGameState = StateType.MainMenu;
    }

    void FillGameStateDictionary()
    {
        gameStates.DoForAll((item) =>
        {
            gameStateDict.Add(item.stateType, item.script.GetComponent<IState>());
        });
    }

    void BindButtonClicks()
    {
        uiManager.OnClickStartButton += OnStartButtonClicked;
        uiManager.OnClickContinueButton += OnContinueButtonClicked;
        inputManager.OnClickedBackButton += OnBackButtonClicked;
    }

    #region On Click Button Event Functions

    void OnStartButtonClicked()
    {
        CurrentGameState = StateType.InGame;
        levelManager.CreateLevel(1);
        OnLevelChanged(1);
    }

    void OnContinueButtonClicked()
    {
        CurrentGameState = StateType.InGame;
    }

    void OnBackButtonClicked()
    {
        if (CurrentGameState == StateType.MainMenu)
        {
            return;
        }

        if (CurrentGameState == StateType.Pause)
        {
            CurrentGameState = StateType.InGame;
            return;
        }

        CurrentGameState = StateType.Pause;
    }

    void OnLevelChanged(int currentLevel)
    {
        uiManager.OnLevelChanged?.Invoke(currentLevel);
    }

    void OnLevelProcessChanged(float processAmount)
    {
        uiManager.OnLevelProcessChanged?.Invoke(processAmount);
    }

    #endregion
}

[System.Serializable]
public struct State
{
    public StateType stateType;
    public MonoBehaviour script;
}
