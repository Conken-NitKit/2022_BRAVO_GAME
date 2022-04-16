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
    private GameObject enemyFirstBullet;
    [SerializeField]
    private GameObject enemySecondBullet;
    [SerializeField]
    private GameObject enemyThirdFirstBullet;
    [SerializeField]
    private GameObject enemyThirdSecondBullet;
    [SerializeField]
    private GameObject enemyThirdThirdBullet;

    const float limitLeftMovePosition = -3.5f;
    const float limitRightMovePosition = 3.5f;
    const float firstXPosition = 3.5f;
    const float firstYPosition = 3.5f;
    const float moveTime = 1.1f;
    const float waitTime = 0.7f;
    const float firstBulletInterval = 0.16f;
    const float secondBulletInterval = 0.6f;
    const float LastBulletInteryal = 0.3f;
    const float firstXPositionLastStage = 0f;
    const float firstMoveTimeLastStage = 0.7f;
    const float waitTimeLastStage = 1f;
    

    private void Start()
    {
        this.transform.position = new Vector2(firstXPosition,firstYPosition);
        StartCoroutine(MoveLastNormalStageEnemy());
    }

    ///<summary>
    ///最初の敵の動き   
    ///</summary>
    void MoveFirstNormalStageEnemy()
    {
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearFirstBullet),waitTime,firstBulletInterval);
    }

    ///<summary>
    ///２つ目の敵の動き
    ///</summary>
    void MoveSecondNormalStageEnemy()
    {
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearSecondBullet),waitTime,secondBulletInterval);
    }

    ///<summary>
    ///最後の敵の動き
    ///</summary>
    private IEnumerator MoveLastNormalStageEnemy()
    {
        this.transform.DOMove(new Vector2(firstXPositionLastStage,firstYPosition),firstMoveTimeLastStage);
        Invoke(nameof(AppearThirdFirstBullet),waitTime);
        yield return new WaitForSeconds(waitTimeLastStage);
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),firstMoveTimeLastStage);
        yield return new WaitForSeconds(waitTime);
        this.transform.DOMove(new Vector2(limitRightMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        float numberTime = 0f;
        float maxNumberTime = 28f;
        while (numberTime < maxNumberTime)
        {
            if((numberTime == 4) || (numberTime == 16) || (numberTime == 24))
            {
                AppearSecondBullet();
            }else if(numberTime == 23){
                AppearThirdThirdBullet();
            }else{
                AppearFirstBullet();
            }
            yield return new WaitForSeconds(LastBulletInteryal);
            if((numberTime == 2) || (numberTime == 10) || (numberTime == 27))
            {
                AppearThirdSecondBullet();
            }else if(numberTime == 18){
                AppearFirstBullet();
                AppearSecondBullet();
            }else{
                AppearFirstBullet();
            }
            yield return new WaitForSeconds(LastBulletInteryal);
            if((numberTime == 6) || (numberTime == 12) || (numberTime == 15) || (numberTime == 26))
            {
                AppearThirdSecondBullet();
            }else if((numberTime == 0) || (numberTime == 17)){
                AppearThirdFirstBullet();
                AppearThirdThirdBullet();
            }else{
                AppearFirstBullet();
            }
            yield return new WaitForSeconds(LastBulletInteryal);
            numberTime++;
        }
    }

    ///<summary>
    ///真下に進む弾を呼び出すメソッド
    ///</summary>
    void AppearFirstBullet()
    {
        Instantiate (enemyFirstBullet,transform.position,Quaternion.identity);
    }
    ///<summary>
    ///プレイヤーに向かって進む弾を呼び出すメソッド
    ///</summary>
    void AppearSecondBullet()
    {
        Instantiate (enemySecondBullet,transform.position,Quaternion.identity);
    }
    ///<summary>
    ///敵を中心に拡がる弾を呼び出すメソッド
    ///</summary>
    void AppearThirdFirstBullet()
    {
        Instantiate (enemyThirdFirstBullet,transform.position,Quaternion.identity);
    }
    ///<summary>
    ///左回転する小型の環状の弾を呼び出すメソッド
    ///</summary>
    void AppearThirdSecondBullet()
    {
        Instantiate (enemyThirdSecondBullet,transform.position,Quaternion.identity);
    }
    ///<summary>
    ///真下に進んだ後拡がる弾を呼び出すメソッド
    ///</summary>
    void AppearThirdThirdBullet()
    {
        Instantiate (enemyThirdThirdBullet,transform.position,Quaternion.identity);
    }
}
