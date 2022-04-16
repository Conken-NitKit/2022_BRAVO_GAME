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
        scoreText.text = "すこあ " + playerStatus.playerGraze.ToString();
    }    
}
