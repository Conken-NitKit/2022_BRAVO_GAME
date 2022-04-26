using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトル画面におけるボタンの動きを管理するクラス
/// </summary>
public class SceneTransitionButton : MonoBehaviour
{

    [SerializeField] private SCENES scene; //ボタンを押したときシーンを遷移する

    public enum SCENES
    {
        Easy,
        Normal,
        Hard,
        Title,
    }

    /// <summary>
    /// ボタンがクリックされたときボタンが一瞬拡大する
    /// </summary>
    public void OnClicked()
    {
        Time.timeScale = 1f;
        transform.DOScale(1.1f,0.5f).SetEase(Ease.OutElastic)
        .OnComplete(() =>
        {
            Utils.DestroyGameObjectsWithTag("Bullet");
            transform.DOScale(1f, 0.5f);
        }).OnComplete(() => SceneManager.LoadScene($"{scene}"));    
    }
    
}
