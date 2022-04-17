using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追尾弾の生成の名前空間
/// </summary>
public class SpoonHomingBullet : MonoBehaviour
{
    public GameObject HomingBullet;
    float Seconds = 0;
    
    void Start()
    {
        Spoon();
    }
    void Update()
    {
        Seconds += Time.deltaTime;
        //Debug.Log(Seconds);
        if(Seconds>=3)
        {
            Spoon();
            Seconds = 0;
        }
    }
    void Spoon()
    {
        Instantiate(HomingBullet,this.transform.position,this.transform.rotation);
    }

}
