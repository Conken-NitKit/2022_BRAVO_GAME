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
    /// 難しいモードの敵のクラス
    /// </summary>
    public class EnemyHardMode : MonoBehaviour
    {
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
        private GameObject thirdStageBullet;

        private float generateSpan = 2f;

        [SerializeField]
        private Transform[] secondStageBulletSpawnPositions;


        /// <summary>
        /// 第一ステージの動き
        /// </summary>
        public void MoveFirstStage()
        {
            this.gameObject.transform.position = new Vector3(0, 3f, 0);

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
            this.gameObject.transform.position = new Vector3(0, 3f, 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0);

            this.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 0.8f, RotateMode.FastBeyond360).OnStepComplete(() =>
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
        /// 第三ステージの動き
        /// </summary>
        public void MoveThirdStage()
        {
            this.gameObject.transform.position = new Vector3(0, 4f, 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0);

            this.transform.DOLocalRotate(new Vector3(0, 0, generateSpan),
            generateSpan / 360f,
            RotateMode.FastBeyond360).OnStepComplete(() =>
            {
                Instantiate(thirdStageBullet, this.gameObject.transform.position, Quaternion.identity);
            })
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
        }
    }
}