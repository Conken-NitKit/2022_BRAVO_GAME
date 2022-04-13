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
    
    const float limitLeftMovePosition = -3.5f;
    const float firstYPosition = 3.5f;
    const float moveTime = 1.1f;
    const float waitTime = 0.7f;
    const float firstBulletInterval = 0.16f;
    const float secondBulletInterval = 0.6f;

    private void Start()
    {
        MoveSecondNormalStageEnemy();
    }

    ///<summary>
    ///最初の敵の動き   
    ///</summary>
    void MoveFirstNormalStageEnemy()
    {
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearBullet),waitTime,firstBulletInterval);
    }

    ///<summary>
    ///２つ目の敵の動き
    ///</summary>
    void MoveSecondNormalStageEnemy()
    {
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearBullet),waitTime,secondBulletInterval);
    }

    ///<summary>
    ///弾を呼び出すメソッド
    ///</summary>
    void AppearBullet()
    {
        Instantiate (enemyBullet,transform.position,Quaternion.identity);
    }
}
