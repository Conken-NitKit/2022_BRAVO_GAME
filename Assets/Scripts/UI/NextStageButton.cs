using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// 次へボタンを押した時の処理
/// </summary>
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

    /// <summary>
    /// 次へ行くボタンを押した時の動作
    /// </summary>
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
