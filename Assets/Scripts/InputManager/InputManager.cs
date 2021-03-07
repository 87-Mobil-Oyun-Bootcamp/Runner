using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public System.Action OnClickedBackButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnClickedBackButton?.Invoke();
        }
    }
}
