using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using System.Threading.Tasks;

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
        [SerializeField] private UnityEvent moveEvent;
        [SerializeField] private GameObject spawner1st;
        [SerializeField] private GameObject homingBullet2nd;
        [SerializeField] private GameObject homingBullet3rd;
        private Vector3[] path2nd = 
        {
            new Vector3(0f,4f,0f),
            new Vector3(-3f,3f,0f),
            new Vector3(0f,2f,0f),
            new Vector3(3f,3f,0f),
            new Vector3(0f,4f,0f)
        };
        private Vector3[] path3rd = 
        {
            new Vector3(0f,4f,0f),
            new Vector3(-3f,4f,0f),
            new Vector3(-3f,-4f,0f),
            new Vector3(3f,-4f,0f),
            new Vector3(3f,4f,0f),
            new Vector3(0f,4f,0f),
            new Vector3(-3f,4f,0f)
        };

        private void Start()
        {
            moveEvent.Invoke();
        }

        /// <summary>
        /// 第一ステージの行動
        /// </summary>
        public void Move1stStage()
        {
            this.transform.DOMove(new Vector2(0f,4f),2f);
            Instantiate(spawner1st, this.transform.position, this.transform.rotation);
        }

        /// <summary>
        /// 第二ステージの行動
        /// </summary>
        public void Move2ndStage()
        {
            this.transform.position = new Vector3(0f,4f,0f);
            this.transform.DOPath(path2nd,10f).SetLoops(3,LoopType.Restart);
            InvokeRepeating(nameof(Spawn2nd),0f,3f);
        }

        /// <summary>
        /// 第三ステージの行動
        /// </summary>
        public void Move3rdStage()
        {
            this.transform.position = new Vector3(0f,4f,0f);
            this.transform.DOPath(path3rd,15f).SetEase(Ease.OutSine).SetLoops(2,LoopType.Yoyo);
            InvokeRepeating(nameof(Spawn3rd),0f,2f);
        }

        /// <summary>
        /// 第二ステージの弾の生成
        /// </summary>
        void Spawn2nd()
        {
            Instantiate(homingBullet2nd, this.transform.position, this.transform.rotation);
        }

        

        /// <summary>
        /// 第三ステージの弾の生成
        /// </summary>
        void Spawn3rd()
        {
            Instantiate(homingBullet3rd, this.transform.position, this.transform.rotation);
        }
    }
}
