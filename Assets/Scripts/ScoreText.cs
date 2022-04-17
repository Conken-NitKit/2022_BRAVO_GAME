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

    private void Start()
    {
       SetScore(); 
    }
    
    public void SetScore()
    {
        scoreText.text = $"ぐれいず : {playerStatus.playerGraze}";
        transform.DOPunchScale(new Vector2(0.1f, 0.1f), 0.02f);
    }
}
