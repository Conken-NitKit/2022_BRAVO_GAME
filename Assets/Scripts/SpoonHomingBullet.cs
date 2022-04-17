using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追尾弾の生成の名前空間
/// </summary>
public class SpoonHomingBullet : MonoBehaviour
{
    [SerializeField] private GameObject HomingBullet;
    float seconds = 0;
    
    void Start()
    {
        Spoon();
    }
    void Update()
    {
        seconds += Time.deltaTime;
        //Debug.Log(Seconds);
        if(seconds>=3)
        {
            Spoon();
            seconds = 0;
        }
    }
    void Spoon()
    {
        Instantiate(HomingBullet,this.transform.position,this.transform.rotation);
    }

}
