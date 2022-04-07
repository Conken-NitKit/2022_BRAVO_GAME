using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

namespace EnemyMove
{
    public class EnemyHardMode : MonoBehaviour
    {
        [SerializeField]
        private GameObject firstStageBullet;

        private void Start()
        {
            MoveFirstStage();
        }

        public async void MoveFirstStage()
        {
            for(int i = 0; i < 60; i++)
            {
                this.transform.DOMove(new Vector3(Random.Range(-4f , 4f), Random.Range(-5f, 5f), 0f), 0.5f);
                this.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 0.5f, RotateMode.FastBeyond360);

                Instantiate(firstStageBullet, this.gameObject.transform.position, Quaternion.identity);

                await Task.Delay(500);
            }
        }
    }
}