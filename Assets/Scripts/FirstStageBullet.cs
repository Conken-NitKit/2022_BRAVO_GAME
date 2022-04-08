using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class FirstStageBullet : MonoBehaviour
{
    private float forceFirstMove = 3f;

    [SerializeField]
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody.AddForce(transform.up * forceFirstMove, ForceMode2D.Impulse);
    }
}
