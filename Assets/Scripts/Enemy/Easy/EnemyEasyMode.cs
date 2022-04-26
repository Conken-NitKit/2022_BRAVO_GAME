using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// 敵の動きの名前空間
/// </summary>
namespace EnemyMove
{
    /// <summary>
    /// 簡単モードの敵のクラス
    /// </summary>
    public class EnemyEasyMode : MonoBehaviour
    {
        [SerializeField] private GameObject homingBulletFirst;
        [SerializeField] private GameObject homingBulletSecond;
        [SerializeField] private GameObject homingBulletThird;
        private Vector3[] pathSecond = 
        {
            new Vector3(0f,4f,0f),
            new Vector3(-3f,3f,0f),
            new Vector3(0f,2f,0f),
            new Vector3(3f,3f,0f),
            new Vector3(0f,4f,0f)
        };
        private Vector3[] pathThird = 
        {
            new Vector3(0f,4f,0f),
            new Vector3(-3f,4f,0f),
            new Vector3(-3f,-4f,0f),
            new Vector3(3f,-4f,0f),
            new Vector3(3f,4f,0f),
            new Vector3(0f,4f,0f),
            new Vector3(-3f,4f,0f)
        };


        /// <summary>
        /// 第一ステージの行動
        /// </summary>
        public void MoveFirstStage()
        {
            this.transform.DOMove(new Vector2(0f,3f),2f);
            InvokeRepeating(nameof(SpawnFirst),0f,3f);
        }

        /// <summary>
        /// 第二ステージの行動
        /// </summary>
        public void MoveSecondStage()
        {
            this.transform.position = new Vector3(0f,4f,0f);
            this.transform.DOPath(pathSecond,10f).SetLoops(3,LoopType.Restart);
            InvokeRepeating(nameof(SpawnSecond),0f,3f);
        }

        /// <summary>
        /// 第三ステージの行動
        /// </summary>
        public void MoveThirdStage()
        {
            this.transform.position = new Vector3(0f,4f,0f);
            this.transform.DOPath(pathThird,15f).SetEase(Ease.OutSine).SetLoops(2,LoopType.Yoyo);
            InvokeRepeating(nameof(SpawnThird),0f,2f);
        }

        /// <summary>
        /// 第一ステージの弾の生成
        /// </summary>
        void SpawnFirst()
        {
            Instantiate(homingBulletFirst, this.transform.position, this.transform.rotation);
        }

        /// <summary>
        /// 第二ステージの弾の生成
        /// </summary>
        void SpawnSecond()
        {
            Instantiate(homingBulletSecond, this.transform.position, this.transform.rotation);
        }

        /// <summary>
        /// 第三ステージの弾の生成
        /// </summary>
        void SpawnThird()
        {
            Instantiate(homingBulletThird, this.transform.position, this.transform.rotation);
        }
    }
}
