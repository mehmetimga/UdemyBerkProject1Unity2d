using UnityEngine;
using UdemyBerkProject1.Controllers;
using UdemyBerkProject1.Abstracts.Spawners;
using UdemyBerkProject1.Pools;

namespace UdemyBerkProject1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController poolEnemy = ObstaclePool.Instance.Get();
            poolEnemy.transform.position = new Vector3(10, -6, 0); //this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }

}
