using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NextStageButton : MonoBehaviour
{
    [SerializeField]
    private TimeManager timeManager;

    [SerializeField]
    private Text buttonText;

    [SerializeField]
    private UnityEvent[] moveEvent;

    [SerializeField]
    private GameObject[] gamePauseUIs;

    private int moveEventIndex = 0;

    public void OnClickedNextStageButton()
    {
        Time.timeScale = 1f;
        timeManager.CountDownTime();
        moveEvent[moveEventIndex].Invoke();

        if(moveEventIndex == 0)
        {
            buttonText.text = "つぎのすてーじ";
        }

        moveEventIndex++;

        foreach(GameObject gamePauseUI in gamePauseUIs)
        {
            gamePauseUI.SetActive(false);
        }
    }
}
