using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の最後の敵の弾の動きの処理１
///</summary>
public class NormalStageThirdEnemyBulletFirst : MonoBehaviour
{
    [SerializeField]
    private float xMoveValue;
    [SerializeField]
    private float yMoveValue;
    [SerializeField]
    private Rigidbody2D rigitBody;

    ///<summary>
    ///指定した方向に直進する。拡がる弾に使う。
    ///</summary>
    void Update()
    {
        rigitBody.AddForce(new Vector2(xMoveValue, yMoveValue));
    }
}
