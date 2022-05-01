using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameOverObjects;

    [SerializeField]
    private GameObject[] gameObjects;

    [SerializeField]
    private Text gameOverText;

    [SerializeField]
    private ResultScoreText scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;

            Utils.DestroyGameObjectsWithTag("Bullet");

            Destroy(this.gameObject);

            DOTween.KillAll();

            CancelInvoke();

            gameOverText.text = "Game Over";

            scoreText.SetResultScore();

            foreach (GameObject gameOverObject in gameOverObjects)
            {
                gameOverObject.SetActive(true);
            }
        }
    }
}
