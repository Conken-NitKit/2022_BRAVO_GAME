using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

///<summary>
///普通難易度の敵の動きの処理
///</summary>
namespace EnemyMove
{
    public class NormalStageEnemy : MonoBehaviour
    {
        [SerializeField]
        private GameObject enemyFirstBullet;
        [SerializeField]
        private GameObject enemySecondBullet;
        [SerializeField]
        private GameObject[] enemyThirdBullets;

        private const float limitLeftMovePosition = -4f;
        private const float firstXPosition = 4f;
        private const float firstYPosition = 3.5f;
        private const float moveTime = 1.1f;
        private const float firstBulletInterval = 0.16f;
        private const float secondBulletInterval = 0.6f;
        private const float waitTimeThirdStage = 2f;


        ///<summary>
        ///一つ目の敵の動き   
        ///</summary>
        public void MoveFirstNormalStageEnemy()
        {
            this.transform.position = new Vector2(firstXPosition, firstYPosition);
            this.transform.DOMove(new Vector2(limitLeftMovePosition, firstYPosition), moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
            InvokeRepeating(nameof(AppearFirstBullet), 0, firstBulletInterval);
        }

        ///<summary>
        ///二つ目の敵の動き
        ///</summary>
        public void MoveSecondNormalStageEnemy()
        {
            this.transform.position = new Vector2(firstXPosition, firstYPosition);
            this.transform.DOMove(new Vector2(limitLeftMovePosition, firstYPosition), moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
            InvokeRepeating(nameof(AppearSecondBullet), 0, secondBulletInterval);
        }

        ///<summary>
        ///三つ目の敵の動き
        ///</summary>
        public void MoveThirdNormalStageEnemy()
        {
            this.transform.position = new Vector2(firstXPosition, firstYPosition);
            this.transform.DOMove(new Vector2(limitLeftMovePosition, firstYPosition), moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);

            InvokeRepeating(nameof(AppearThirdBullet), 0, waitTimeThirdStage);
        }

        ///<summary>
        ///普通難易度の一つ目のステージの弾を生成するメソッド
        ///</summary>
        void AppearFirstBullet()
        {
            if (Time.timeScale != 0f)
            {
                Instantiate(enemyFirstBullet, transform.position, Quaternion.identity);
            }
        }

        ///<summary>
        ///普通難易度の二つ目のステージの弾を生成するメソッド
        ///</summary>
        void AppearSecondBullet()
        {
            if (Time.timeScale != 0f)
            {
                Instantiate(enemySecondBullet, transform.position, Quaternion.identity);
            }
        }

        ///<summary>
        ///普通難易度の三つ目のステージの弾を生成するメソッド
        ///</summary>
        void AppearThirdBullet()
        {
            if (Time.timeScale != 0f)
            {
                Instantiate(enemyThirdBullets[Random.Range(0, enemyThirdBullets.Length)], transform.position, Quaternion.identity);
            }
        }
    }
}
