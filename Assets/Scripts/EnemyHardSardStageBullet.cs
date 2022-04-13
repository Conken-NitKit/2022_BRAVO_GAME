using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 難しい第三ステージの敵の弾
/// </summary>
public class EnemyHardSardStageBullet : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    private float bulletSpeed = 400f;

    void Start()
    {
        rigidBody.AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f),0).normalized * bulletSpeed, ForceMode2D.Force);//ランダムレンジは方向指定してるだけ
    }
}
