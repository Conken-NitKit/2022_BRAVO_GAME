using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float limitSeconds { get; private set; }

    private float timeCountWaitSeconds = 0.02f;

    [SerializeField]
    private Text timerText;

    void Start()
    {
        StartCoroutine(CountDownTime());
    }

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public IEnumerator CountDownTime()
    {
        limitSeconds = 30;

        while (limitSeconds >= 0)
        {
            limitSeconds -= timeCountWaitSeconds;
            timerText.text = limitSeconds.ToString("f2");
            transform.DOPunchScale(new Vector2(0.1f,0.1f),timeCountWaitSeconds);
            
            yield return new WaitForSeconds(timeCountWaitSeconds);
        }
    }
}
