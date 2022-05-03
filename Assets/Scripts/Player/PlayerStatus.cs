using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーのステータス管理のクラス
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    public int playerGraze { get; set; }

    void Start()
    {
        playerGraze = 0;
    }

    /// <summary>
    /// グレイズを増やすメソッド
    /// </summary>
    public void IncreaseGraze(int point = 1)
    {
        playerGraze += point;
    }
}
