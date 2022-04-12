using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHardSardStageBullet : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody.AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f),0) * 500f, ForceMode2D.Force);
    }
}
