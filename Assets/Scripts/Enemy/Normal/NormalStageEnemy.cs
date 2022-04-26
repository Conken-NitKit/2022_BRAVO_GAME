using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

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

    const float limitLeftMovePosition = -4f;
    const float limitRightMovePosition = 3.5f;
    const float firstXPosition = 4f;
    const float firstYPosition = 3.5f;
    const float moveTime = 1.1f;
    const float waitTime = 0.7f;
    const float firstBulletInterval = 0.16f;
    const float secondBulletInterval = 0.6f;
    const float lastBulletInteryall = 0.3f;
    const float firstXPositionLastStage = 0f;
    const float firstMoveTimeLastStage = 0.7f;
    const float waitTimeLastStage = 1f;


    ///<summary>
    ///最初の敵の動き   
    ///</summary>
    public void MoveFirstNormalStageEnemy()
    {
        this.transform.position = new Vector2(firstXPosition, firstYPosition);
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearFirstBullet),waitTime,firstBulletInterval);
    }

    ///<summary>
    ///２つ目の敵の動き
    ///</summary>
    public void MoveSecondNormalStageEnemy()
    {
        this.transform.position = new Vector2(firstXPosition, firstYPosition);
        this.transform.DOMove(new Vector2(limitLeftMovePosition,firstYPosition),moveTime).SetDelay(waitTime).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine);
        InvokeRepeating(nameof(AppearSecondBullet),waitTime,secondBulletInterval);
    }

    ///<summary>
    ///最後の敵の動き
    ///</summary>
    public void MoveLastNormalStageEnemy()
    {
        this.transform.position = new Vector2(firstXPosition, firstYPosition);
        this.transform.DOMove(new Vector2(limitLeftMovePosition, firstYPosition), moveTime).SetDelay(waitTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);

        InvokeRepeating(nameof(AppearThirdBullet), waitTime, waitTimeLastStage);
    }

    ///<summary>
    ///真下に進む弾を呼び出すメソッド
    ///</summary>
    void AppearFirstBullet()
    {
        if(Time.timeScale != 0f)
        {
            Instantiate (enemyFirstBullet,transform.position,Quaternion.identity);
        }
    }
    ///<summary>
    ///プレイヤーに向かって進む弾を呼び出すメソッド
    ///</summary>
    void AppearSecondBullet()
    {
        if (Time.timeScale != 0f)
        {
            Instantiate (enemySecondBullet,transform.position,Quaternion.identity);
        }
    }

    void AppearThirdBullet()
    {
        int fanctionNumber = 3;

        int fanctionIndex = Random.Range(0, fanctionNumber);

        if(fanctionIndex == 0)
        {
            AppearThirdFirstBullet();
        }
        else if(fanctionIndex == 1)
        {
            AppearThirdSecondBullet();
        }
        else if(fanctionIndex == 2)
        {
            AppearThirdThirdBullet();
        }
    }


    ///<summary>
    ///敵を中心に拡がる弾を呼び出すメソッド
    ///</summary>
    void AppearThirdFirstBullet()
    {
        if (Time.timeScale != 0f)
        {
            Instantiate (enemyThirdFirstBullet,transform.position,Quaternion.identity);
        }
    }
    ///<summary>
    ///左回転する小型の環状の弾を呼び出すメソッド
    ///</summary>
    void AppearThirdSecondBullet()
    {
        if (Time.timeScale != 0f)
        {
            Instantiate (enemyThirdSecondBullet,transform.position,Quaternion.identity);
        }
    }
    ///<summary>
    ///真下に進んだ後拡がる弾を呼び出すメソッド
    ///</summary>
    void AppearThirdThirdBullet()
    {
        if (Time.timeScale != 0f)
        {
            Instantiate (enemyThirdThirdBullet,transform.position,Quaternion.identity);
        }
    }
}
