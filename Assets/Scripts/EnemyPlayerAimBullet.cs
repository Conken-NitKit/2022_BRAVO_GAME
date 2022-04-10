using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyPlayerAimBullet : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(GameObject.Find("Player").transform.position, 0.5f)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}
