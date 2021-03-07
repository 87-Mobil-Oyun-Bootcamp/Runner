using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InGamePanelController : MonoBehaviour
{
    [Space]
    [SerializeField]
    TextMeshProUGUI previousLevelText;
    [SerializeField]
    TextMeshProUGUI nextLevelText;

    [SerializeField]
    Image levelProcessImage;

    public void UpdateLevel(int currentLevel)
    {
        previousLevelText.text = currentLevel.ToString();
        nextLevelText.text = (currentLevel + 1).ToString();
    }

    public void UpdateLevelProcess(float process)
    {
        // TODO: Handle Level Process Changed!
    }
}
