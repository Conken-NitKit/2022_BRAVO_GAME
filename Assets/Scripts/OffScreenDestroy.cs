using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 画面外に出た時のクラス
/// </summary>
public class OffScreenDestroy : MonoBehaviour
{
    /// <summary>
    /// 画面外に出た時のメソッド
    /// </summary>
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
