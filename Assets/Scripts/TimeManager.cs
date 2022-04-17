using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.Threading.Tasks;

public class TimeManager : MonoBehaviour
{
    public float limitSeconds { get; private set; }

    private float timeCountWaitSeconds = 0.02f;

    private int stageIndex;

    private int maxStageIndex = 3;

    [SerializeField]
    private Text timerText;

    [SerializeField]
    private GameObject[] gamePauseUIs;

    [SerializeField]
    private GameObject titleButton;

    private void Start()
    {
        stageIndex = 0;
        Time.timeScale = 0f;
    }

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public async void CountDownTime()
    {
        limitSeconds = 30;

        transform.DOPunchScale(new Vector2(0.1f,0.1f),timeCountWaitSeconds).SetLoops(-1, LoopType.Restart).SetDelay(timeCountWaitSeconds);

        while (limitSeconds >= 0 && Time.timeScale != 0f)
        {
            limitSeconds -= timeCountWaitSeconds;
            timerText.text = "たいむ: " + limitSeconds.ToString("f2");

            await Task.Delay((int)(timeCountWaitSeconds * 1000));
        }

        stageIndex++;

        DOTween.KillAll();
        Utils.DestroyGameObjectsWithTag("Bullet");

        foreach (GameObject gamePauseUI in gamePauseUIs)
        {
            gamePauseUI.SetActive(true);
        }

        if(stageIndex == maxStageIndex)
        {
            titleButton.SetActive(true);
        }

        Time.timeScale = 0f;
    }
}
