using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトル画面におけるボタンの動きを管理するクラス
/// </summary>
public class TitleButton : MonoBehaviour
{
    /// <summary>
    /// ボタンがクリックされたときボタンが一瞬拡大する
    /// </summary>
    public void OnClicked()
    {
        Sequence sequence = DOTween.Sequence();
        transform.DOScale(1.1f,0.5f).SetEase(Ease.OutElastic).OnComplete(() => transform.DOScale(1f,0.5f)).OnComplete(() => SceneManager.LoadScene(""));    
    }
    
}
