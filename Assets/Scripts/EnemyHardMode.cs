using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine.Events;

/// <summary>
/// 敵の動きの名前空間
/// </summary>
namespace EnemyMove
{
    /// <summary>
    /// 難しいモードの敵のクラス
    /// </summary>
    public class EnemyHardMode : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent moveEvent;

        [SerializeField]
        private GameObject enemyPlayerAimBullet;

        [SerializeField]
        private GameObject firstStageBullet;

        private const float MinPositionX = -4f;
        private const float MaxPositionX = 4f;

        private const float MinPositionY = -4f;
        private const float MaxPositionY = 5f;

        private float enemyMoveTime = 0.5f;

        [SerializeField]
        private GameObject secondStageBullet;

        [SerializeField]
        private GameObject sardStageBullet;

        private float generateSpan = 2f;

        [SerializeField]
        private Transform[] secondStageBulletSpawnPositions;

        private void Start()
        {
            moveEvent.Invoke();
        }

        /// <summary>
        /// 第一ステージの動き
        /// </summary>
        public void MoveFirstStage()
        {
            this.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), enemyMoveTime, RotateMode.FastBeyond360).OnStepComplete(() =>
            {
                this.transform.DOMove(new Vector3(Random.Range(MinPositionX, MaxPositionX), Random.Range(MinPositionY, MaxPositionY), 0f), enemyMoveTime);
                Instantiate(firstStageBullet, this.gameObject.transform.position, Quaternion.identity);
            })
            .SetLoops(-1, LoopType.Restart);
        }

        /// <summary>
        /// 第二ステージの動き
        /// </summary>
        public void MoveSecondStage()
        {
            this.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 1f, RotateMode.FastBeyond360).OnStepComplete(() =>
            {
                Instantiate(enemyPlayerAimBullet, this.gameObject.transform.position, Quaternion.identity);

                foreach (Transform secondStageBulletSpawnPosition in secondStageBulletSpawnPositions)
                {
                    Instantiate(secondStageBullet, secondStageBulletSpawnPosition.position, Quaternion.identity);
                }
            })
            .SetLoops(-1, LoopType.Restart);
        }

        /// <summary>
        /// 第二ステージの動き
        /// </summary>
        public void MoveSardStage()
        {
            this.transform.DOLocalRotate(new Vector3(0, 0, generateSpan),
            generateSpan / 360f,
            RotateMode.FastBeyond360).OnStepComplete(() =>
            {
                Instantiate(sardStageBullet, this.gameObject.transform.position, Quaternion.identity);
            })
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
        }
    }
}