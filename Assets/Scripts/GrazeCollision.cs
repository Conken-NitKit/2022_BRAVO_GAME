using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrazeCollision : MonoBehaviour
{
    [SerializeField]
    PlayerStatus playerStatus;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            playerStatus.IncreaseGraze();
        }
    }
}
