using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyEasyMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector2(0f,4f),3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
