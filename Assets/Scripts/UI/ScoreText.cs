using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// スコアのアニメーションを管理するクラス
/// </summary>
public class ScoreText : MonoBehaviour
{

    [SerializeField]private PlayerStatus playerStatus;

    public Text scoreText;

    Vector3 defaultScale;

    private void Start()
    {
        defaultScale = this.transform.localScale;
        SetScore(); 
    }

    /// <summary>
    /// スコアを設定するメソッド
    /// </summary>
    public void SetScore()
    {
        scoreText.text = $"ぐれいず : {playerStatus.playerGraze}";
        transform.DOKill();
        transform.localScale = defaultScale;
        transform.DOPunchScale(new Vector2(0.1f, 0.1f), 0.02f);
    }
}
