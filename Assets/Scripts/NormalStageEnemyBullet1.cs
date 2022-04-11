using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の最初の敵の弾の動きの処理
///</summary>
public class NormalStageEnemyBullet1 : MonoBehaviour
{
    ///<summary>
    ///真下に向かって直進する
    ///</summary>
    void Update()
    {
        transform.Translate(0,-0.003f,0);
    }
}
