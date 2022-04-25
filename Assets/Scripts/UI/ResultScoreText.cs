using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreText : MonoBehaviour
{
    [SerializeField] private PlayerStatus playerStatus;
    public Text scoreText;

    public void SetResultScore()
    {
        scoreText.text = $"現在のグレイズ回数は\n{playerStatus.playerGraze}回です！";
    }
}
