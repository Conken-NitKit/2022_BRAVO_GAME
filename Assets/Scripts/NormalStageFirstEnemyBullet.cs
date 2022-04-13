using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の最初の敵の弾の動きの処理
///</summary>
public class NormalStageFirstEnemyBullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigitBody;
    ///<summary>
    ///真下に向かって直進する
    ///</summary>
    void Update()
    {
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(0,-0.5f);
        rigitBody.AddForce(force);
    }
}
