using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの動きの処理
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;

    [SerializeField]
    private float playerSlowSpeed;

    private float playerNowSpeed;

    void FixedUpdate()
    {
        MoveSlowPlayer();
        MovePlayer();
    }


    /// <summary>
    /// 矢印キーでプレイヤーの上下移動を制御するメソッド
    /// </summary>
    void MovePlayer()
    {
        Vector3 playerPos = transform.position;

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerPos.y += playerNowSpeed * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerPos.y -= playerNowSpeed * Time.deltaTime;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerPos.x += playerNowSpeed * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerPos.x -= playerNowSpeed * Time.deltaTime;
        }

        transform.position = playerPos;
    }

    /// <summary>
    /// 左シフトキーを押している時にプレイヤーのスピードを遅くするメソッド
    /// </summary>
    void MoveSlowPlayer()
    {
        playerNowSpeed = (Input.GetKey(KeyCode.LeftShift)) ? playerSlowSpeed : playerSpeed;
    }
}
