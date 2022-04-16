using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の最後の敵の弾の動きの処理４
///</summary>
public class NormalStageLastEnemyBulletForth : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigitBody;
    [SerializeField]
    private GameObject enemyLastFirstBullet;

    const float flyTime = 1.1f;
    const float destroyTime = 1.2f;
    ///<summary>
    ///拡がる弾を呼び出した後消える
    ///</summary>
    void Start()
    {
        Invoke(nameof(AppearLastFirstBullet),flyTime);
        Destroy(this.gameObject,destroyTime);
    }
    ///<summary>
    ///真下に向かって直進する
    ///</summary>
    void Update()
    {
        Vector2 force = new Vector2(0,-0.5f);
        rigitBody.AddForce(force);
    }
    ///<summary>
    ///拡がる弾を呼び出す
    ///</summary>
    void AppearLastFirstBullet()
    {
        Instantiate (enemyLastFirstBullet,transform.position,Quaternion.identity);
    }
}
