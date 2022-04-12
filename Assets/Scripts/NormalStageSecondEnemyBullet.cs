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

    //float Speed = 0.004f;
    Vector2 startposition;
    Vector2 playerposition;
    Vector2 headingposition;

    private void Start()
    {
        startposition = this.transform.position;
        playerposition = player.position;
        headingposition = playerposition;
        
        StartCoroutine(BulletMove());
    }

    IEnumerator BulletMove()
    {
        float time = 0f;
        Vector2 vec = (headingposition - startposition).normalized;
        Vector2 force = (vec*0.5f);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        while(time < 0.8f)
        {
            time += Time.deltaTime;
            rb.AddForce(force);
            yield return null;
        }
        rb.velocity = Vector2.zero;

        yield return new WaitForSeconds(1);

        time = 0f;
        playerposition = player.position;
        headingposition = playerposition;
        startposition = transform.position;
        vec = (headingposition - startposition).normalized;
        force = (vec*0.7f);
        while(time < 100f)
        {
            time += Time.deltaTime;
            rb.AddForce(force);
            yield return null;
        }
    }
}
