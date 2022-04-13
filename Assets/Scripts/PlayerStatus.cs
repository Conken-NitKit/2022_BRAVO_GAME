using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int playerGraze { get; set; }

    void Start()
    {
        playerGraze = 0;
    }

    private void IncreaseGraze(int point = 1)
    {
        playerGraze = point;
    }
}
