using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NormalStageEnemy : MonoBehaviour
{  
    public GameObject EnemyBullet;
    private void Start()
    {
        MoveFirstNormalStageEnemy();
        InvokeRepeating(nameof(AppearBullet),0.7f,0.6f);
        Invoke(nameof(StageClear),30f);
    }
    //敵の動きの処理
    public void MoveFirstNormalStageEnemy()
    {
            this.transform.DOMove(new Vector3(-3.5f,3.5f,0f),1.1f).SetDelay(0.7f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        
    }

    //弾を呼び出す処理
    void AppearBullet()
    {
        Instantiate (EnemyBullet,transform.position,Quaternion.identity);
    }

    //敵の動きを止める処理
    void StageClear()
    {
        DOTween.KillAll();
        CancelInvoke();
    }
}
