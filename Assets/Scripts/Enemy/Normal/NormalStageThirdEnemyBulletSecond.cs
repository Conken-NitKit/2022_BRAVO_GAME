using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
///<summary>
///普通難易度の最後の敵の弾の動きの処理２
///</summary>
public class NormalStageThirdEnemyBulletSecond : MonoBehaviour
{
    const float rotationTime = 6f;
    const float downTime = 1.8f;
    const float waitTime = 1.6f;
    const float riseTime = 3f;
    const float downYPosition = -3.2f;
    const float riseYPosition = 6.5f;
    const float rotateX = 0f;
    const float rotateY = 0f;
    const float rotateZ = 360f;

    ///<summary>
    ///左回転しながら下に進み、しばらくしてから上に戻っていく
    ///</summary>
    void Start()
    {
        transform.DOLocalRotate(new Vector3(rotateX,rotateY,rotateZ),rotationTime,RotateMode.FastBeyond360);
        transform.DOMoveY(downYPosition,downTime).SetEase(Ease.OutCirc);
        transform.DOMoveY(riseYPosition,riseTime).SetDelay(waitTime).SetEase(Ease.InCubic);
    }
}
