using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// タイトル画面におけるかんたんモードのボタンを管理するクラス
/// </summary>
public class TitleButton : MonoBehaviour
{

public void OnClicked() {
    transform.DOScale(1.1f,0.5f).SetEase(Ease.OutElastic).OnComplete(() => transform.DOScale(1f,0.5f));
}
    
}
