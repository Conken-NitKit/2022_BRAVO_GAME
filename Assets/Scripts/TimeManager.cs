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

    [SerializeField]
    private Text timerText;

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public async void CountDownTime()
    {
        limitSeconds = 30;

        while (limitSeconds >= 0)
        {
            limitSeconds -= timeCountWaitSeconds;
            timerText.text = limitSeconds.ToString("f2");
            transform.DOPunchScale(new Vector2(0.1f,0.1f),timeCountWaitSeconds);

            await Task.Delay((int)(timeCountWaitSeconds * 1000));
        }
        DOTween.KillAll();
        Utils.DestroyGameObjectsWithTag("Bullet");

        Time.timeScale = 0f;
    }
}
