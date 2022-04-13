using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の２つ目の敵の弾の動きの処理
///</summary>
public class NormalStageSecondEnemyBullet : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Rigidbody2D rigitBody;

    Vector2 startPosition;
    Vector2 playerPosition;

    private void Start()
    {
        startPosition = this.transform.position;
        playerPosition = player.position;
        
        StartCoroutine(BulletMove());
    }

    IEnumerator BulletMove()
    {
        float time = 0f;
        Vector2 vec = (playerPosition - startPosition).normalized;
        Vector2 force = (vec*0.5f);
        while(time < 0.8f)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }
        rigitBody.velocity = Vector2.zero;

        yield return new WaitForSeconds(1);

        time = 0f;
        playerPosition = player.position;
        startPosition = transform.position;
        vec = (playerPosition - startPosition).normalized;
        force = (vec*0.7f);
        while(time < 100f)
        {
            time += Time.deltaTime;
            rigitBody.AddForce(force);
            yield return null;
        }
    }
}
