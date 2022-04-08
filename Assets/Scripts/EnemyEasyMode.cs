using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// 敵の動きの名前空間
/// </summary>
namespace EnemyMoveEasy
{
    /// <summary>
    /// 簡単モードの敵のクラス
    /// </summary>
    public class EnemyEasyMode : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            EntryEnemy();
        }

        /// <summary>
        /// 敵の登場
        /// </summary>
        private void EntryEnemy()
        {
            this.transform.DOMove(new Vector2(0f,4f),3f);
        }
    }
}
