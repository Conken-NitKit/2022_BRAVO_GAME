using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///複数の弾を子オブジェクトにもつ親オブジェクトを消すためのクラス
///</summary>
public class NormalStageDestroyBulletParent : MonoBehaviour
{
    const float destroyTime = 7.2f;

    void Start()
    {
        Destroy(this.gameObject,destroyTime);
    }
}
