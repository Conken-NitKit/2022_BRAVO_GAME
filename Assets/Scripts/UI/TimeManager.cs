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

    [SerializeField]
    private GameObject tweetButton;

    [SerializeField]
    private ResultScoreText scoreText;

    private void Start()
    {
        stageIndex = 0;
        Time.timeScale = 0f;
    }

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public void CountDownTime()
    {
        limitSeconds = 30;

        transform.DOPunchScale(new Vector2(0.1f,0.1f),timeCountWaitSeconds).OnStepComplete(() =>
        {
            limitSeconds -= timeCountWaitSeconds;
            timerText.text = "たいむ: " + limitSeconds.ToString("f2");

            if(limitSeconds <= 0 || Time.timeScale == 0f)
            {
                foreach (GameObject gamePauseUI in gamePauseUIs)
                {
                    gamePauseUI.SetActive(true);
                }

                DOTween.KillAll();

                stageIndex++;

                Utils.DestroyGameObjectsWithTag("Bullet");

                scoreText.SetResultScore();


                if (stageIndex == maxStageIndex)
                {
                    titleButton.SetActive(true);
                    tweetButton.SetActive(true);
                }

                Time.timeScale = 0f;
            }
        })
        .SetLoops(-1, LoopType.Restart)
        .SetDelay(timeCountWaitSeconds);
    }
}
