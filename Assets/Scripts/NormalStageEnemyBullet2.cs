using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///普通難易度の２つ目の敵の弾の動きの処理
///</summary>
public class NormalStageEnemyBullet2 : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    float Speed = 0.004f;
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
        transform.position = startposition;
        while(time < 1f)
        {
            time += Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,headingposition,Speed);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        time = 0f;
        playerposition = player.position;
        headingposition = playerposition;
        startposition = transform.position;
        Vector3 vec = (headingposition - startposition).normalized;
        while(time < 100f)
        {
            time += Time.deltaTime;
            transform.position += (vec * Speed);
            yield return null;
        }
    }
}
