using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// リザルトスコアを表示するクラス
/// </summary>
public class ResultScoreText : MonoBehaviour
{
    [SerializeField] private PlayerStatus playerStatus;
    public Text scoreText;

    /// <summary>
    /// リザルトスコアをセットするメソッド
    /// </summary>
    public void SetResultScore()
    {
        scoreText.text = $"現在のグレイズ回数は\n{playerStatus.playerGraze}回です！";
    }
}
