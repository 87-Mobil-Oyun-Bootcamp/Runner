using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    [Space]
    [SerializeField]
    Button continueButton;

    public System.Action OnClickedContinueButton;

    private void Awake()
    {
        continueButton.onClick.AddListener(ContinueButtonClicked);
    }

    void ContinueButtonClicked()
    {
        OnClickedContinueButton?.Invoke();
    }
}
