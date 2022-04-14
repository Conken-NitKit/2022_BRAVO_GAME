using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float limitSeconds { get; private set; }

    private float timeCountWaitSeconds = 0.02f;

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public IEnumerator CountDownTime()
    {
        limitSeconds = 30;

        while (limitSeconds >= 0)
        {
            limitSeconds -= timeCountWaitSeconds;
            yield return new WaitForSeconds(timeCountWaitSeconds);
        }
    }
}
