using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class EnemyHardSecondStageBullet : MonoBehaviour
{
    private int horizontalDirection;

    private void Start()
    {
        horizontalDirection = (this.transform.position.x < 0) ? 1 : -1;

        transform.DOPath(
            path: new Vector3[]
            {
                new Vector3(1 * horizontalDirection, 0.5f, 0),
                new Vector3(2f * horizontalDirection, 0.5f * -1, 0),
                new Vector3(3 * horizontalDirection, 0, 0)
            },
            duration: 3f,
            pathType: PathType.CatmullRom
        )
        .SetRelative(true)
        .SetLoops(-1, LoopType.Incremental)
        .SetEase(Ease.Linear);
    }
}
