using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

/// <summary>
/// 敵の動きをの名前空間
/// </summary>
namespace EnemyMove
{
    /// <summary>
    /// 難しいモードの敵のクラス
    /// </summary>
    public class EnemyHardMode : MonoBehaviour
    {
        [SerializeField]
        private GameObject firstStageBullet;

        private const float MinPositionX = -4f;
        private const float MaxPositionX = 4f;

        private const float MinPositionY = -5f;
        private const float MaxPositionY = 5f;

        private float enemyMoveTime = 0.5f;

        private void Start()
        {
            MoveFirstStage();
        }

        /// <summary>
        /// ファーストステージの動き
        /// </summary>
        public async void MoveFirstStage()
        {
            for(int i = 0; i < 60; i++)
            {
                this.transform.DOMove(new Vector3(Random.Range(MinPositionX, MaxPositionX), Random.Range(MinPositionY, MaxPositionY), 0f), enemyMoveTime);
                this.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), enemyMoveTime, RotateMode.FastBeyond360);

                Instantiate(firstStageBullet, this.gameObject.transform.position, Quaternion.identity);

                await Task.Delay(500);
            }
        }

        public async void MoveSecondStage()
        {

        }
    }
}