using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///普通難易度の２つ目の敵の弾の動きの処理
///</summary>
public class NormalStageSecondEnemyBullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigitBody;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        
        StartCoroutine(BulletMove());
    }

    /// <summary>
    /// ２つ目の敵の弾の動きのコルーチン
    /// </summary>
    IEnumerator BulletMove()
    {
        float time = 0f;
        const float firstMoveTime = 0.8f;
        const float yMoveSize = -0.5f;
        const int waitTime = 1;

        Vector2 force = new Vector2(0,yMoveSize);

        while(time < firstMoveTime)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }

        rigitBody.velocity = Vector2.zero;

        yield return new WaitForSeconds(waitTime);

        time = 0f;
        Vector2 vec = (player.transform.position - this.transform.position).normalized;

        const float moveSpeed = 0.7f;
        const float secondMoveTime = 100f;

        force = (vec * moveSpeed);

        while(time < secondMoveTime)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }
    }
}
