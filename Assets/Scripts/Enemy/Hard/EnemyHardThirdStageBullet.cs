using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 難しい第三ステージの敵の弾
/// </summary>
public class EnemyHardThirdStageBullet : MonoBehaviour
{
    [SerializeField]
    private Color[] colors;

    [SerializeField]
    private Rigidbody2D rigidBody;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private float bulletSpeed = 400f;

    void Start()
    {
        spriteRenderer.color = colors[Random.Range(0, colors.Length)];
        rigidBody.AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f),0).normalized * bulletSpeed, ForceMode2D.Force);//ランダムレンジは方向指定してるだけ
    }
}
