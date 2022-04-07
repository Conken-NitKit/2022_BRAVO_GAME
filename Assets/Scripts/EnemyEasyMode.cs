using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyEasyMode : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Vector2 targetPosition;
    void Start()
    {
        targetPosition = new Vector2(0f,4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,targetPosition,Time.deltaTime);
    }
}
