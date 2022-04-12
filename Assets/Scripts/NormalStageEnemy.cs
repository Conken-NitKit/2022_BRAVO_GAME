using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

///<summary>
///普通難易度の敵の動きの処理
///</summary>

public class NormalStageEnemy : MonoBehaviour
{  
    [SerializeField]
    private GameObject enemyBullet;

    private void Start()
    {
        MoveSecondNormalStageEnemy();
    }

    ///<summary>
    ///最初の敵の動き   
    ///</summary>
    void MoveFirstNormalStageEnemy()
    {
        this.transform.DOMove(new Vector3(-3.5f,3.5f,0f),1.1f).SetDelay(0.7f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearBullet),0.7f,0.2f);
    }

    ///<summary>
    ///２つ目の敵の動き
    ///</summary>
    void MoveSecondNormalStageEnemy()
    {
        this.transform.DOMove(new Vector3(-3.5f,3.5f,0f),1.1f).SetDelay(0.7f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearBullet),0.7f,0.6f);
    }

    ///<summary>
    ///弾を呼び出すメソッド
    ///</summary>
    void AppearBullet()
    {
        Instantiate (enemyBullet,transform.position,Quaternion.identity);
    }
}
