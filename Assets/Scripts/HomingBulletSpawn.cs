using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追尾弾の生成のクラス
/// </summary>
public class HomingBulletSpawn: MonoBehaviour
{
    [SerializeField] private GameObject homingBullet;
    float seconds = 0;
    
    void Start()
    {
        Spawn();
    }
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds>=3)
        {
            Spawn();
            seconds = 0;
        }
    }
    void Spawn()
    {
        Instantiate(homingBullet,this.transform.position,this.transform.rotation);
    }

}
