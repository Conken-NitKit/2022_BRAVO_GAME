using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

///<summary>
///普通難易度の最初の敵の動きの処理
///</summary>

public class NormalStageEnemy : MonoBehaviour
{  
    [SerializeField]
    private GameObject EnemyBullet;

    private void Start()
    {
        MoveFirstNormalStageEnemy();
        InvokeRepeating(nameof(AppearBullet),0.7f,0.6f);
        Invoke(nameof(StageClear),30f);
    }

    ///<summary>
    ///敵が左右に往復するメソッド
    ///</summary>
    void MoveFirstNormalStageEnemy()
    {
            this.transform.DOMove(new Vector3(-3.5f,3.5f,0f),1.1f).SetDelay(0.7f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        
    }

    ///<summary>
    ///弾を呼び出すメソッド
    ///</summary>
    void AppearBullet()
    {
        Instantiate (EnemyBullet,transform.position,Quaternion.identity);
    }

    ///<summary>
    //敵の動きを止めるメソッド
    ///</summary>
    void StageClear()
    {
        DOTween.KillAll();
        CancelInvoke();
    }
}
