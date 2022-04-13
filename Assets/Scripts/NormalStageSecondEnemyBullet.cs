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

    GameObject player;
    Vector2 startPosition;
    Vector2 playerPosition;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        
        StartCoroutine(BulletMove());
    }

    IEnumerator BulletMove()
    {
        float time = 0f;
        const float firstMoveTime = 0.8f;
        const float xMoveSize = 0;
        const float yMoveSize = -0.5f;
        Vector2 force = new Vector2(xMoveSize,yMoveSize);
        while(time < firstMoveTime)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }
        rigitBody.velocity = Vector2.zero;

        yield return new WaitForSeconds(1);

        time = 0f;
        playerPosition = player.transform.position;
        startPosition = transform.position;
        Vector2 vec = (playerPosition - startPosition).normalized;
        const float moveSpeed = 0.7f;
        const float secondMoveTime = 100f;
        force = (vec*moveSpeed);
        while(time < secondMoveTime)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }
    }
}
