using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// 難しいモードの敵の最初の弾の動き
/// </summary>
public class EnemyHardSecondStageBullet : MonoBehaviour
{
    private int horizontalDirection;

    private float moveRoundSeconds = 3f;

    private void Start()
    {
        horizontalDirection = (this.transform.position.x < 0) ? 1 : -1;

        //通るポイントを決めると円形に動いてくれる
        transform.DOPath(
            path: new Vector3[]
            {
                new Vector3(1f * horizontalDirection, 0.5f, 0),//最初に通る場所
                new Vector3(2f * horizontalDirection, 0, 0),//二番目に通る場所
                new Vector3(3f * horizontalDirection, 0.5f * -1, 0),//三番目に通る場所
                new Vector3(4f * horizontalDirection, 0, 0)//四番目に通る場所
            },
            duration: moveRoundSeconds,
            pathType: PathType.CatmullRom
        )
        .SetRelative(true)
        .SetLoops(-1, LoopType.Incremental)
        .SetEase(Ease.Linear);
    }
}
