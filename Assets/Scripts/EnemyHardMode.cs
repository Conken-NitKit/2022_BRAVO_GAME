using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

namespace EnemyMove
{
    public class EnemyHardMode : MonoBehaviour
    {
        private void Start()
        {
            MoveFirstStage();
        }

        public async void MoveFirstStage()
        {
            while (true)
            {
                this.transform.DOMove(new Vector3(Random.Range(-4f , 4f), Random.Range(-5f, 5f), 0f), 1f);

                await Task.Delay(1000);
            }
        }
    }
}