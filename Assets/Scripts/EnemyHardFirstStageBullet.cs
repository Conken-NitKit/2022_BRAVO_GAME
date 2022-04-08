using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 難しいモードの敵の最初の弾の動き
/// </summary>
public class EnemyHardFirstStageBullet : MonoBehaviour
{
    private float forceFirstMove = 3f;

    [SerializeField]
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody.AddForce(transform.up * forceFirstMove, ForceMode2D.Impulse);
    }
}
