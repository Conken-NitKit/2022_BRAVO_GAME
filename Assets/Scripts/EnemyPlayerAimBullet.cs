using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
///  自機狙いの敵の弾のクラス
/// </summary>
public class EnemyPlayerAimBullet : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    private float bulletSpeed = 400f;

    void Start()
    { 
        rigidBody.AddForce((GameObject.FindWithTag("Player").transform.position - this.transform.position).normalized * bulletSpeed, ForceMode2D.Force);
    }
}
