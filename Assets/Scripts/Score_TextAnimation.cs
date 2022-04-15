using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// スコアのアニメーションを管理するクラス
/// </summary>
public class Score_TextAnimation : MonoBehaviour
{
    private void Start()
    {
        transform.DOPunchScale(new Vector2(0.5f,0.5f),1f);    
    }
}
