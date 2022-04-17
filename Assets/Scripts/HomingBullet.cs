using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追尾弾の名前空間
/// </summary>
namespace HomingBullet
{
    public class HomingBullet : MonoBehaviour
    {

        [SerializeField] float LifeTime = 10f;
        [SerializeField] float Speed = 2.5f;

        // Start is called before the first frame update
        void Start()
        {
            /// <summary>
            /// 追尾弾の寿命
            /// </summary>
            Destroy(this.gameObject, LifeTime);
        }

        // Update is called once per frame
        void Update()
        {
            Homing();
        }
        /// <summary>
        /// 追尾弾の動き
        /// </summary>
        void Homing()
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Time.deltaTime*Speed);
        }
    }
}
