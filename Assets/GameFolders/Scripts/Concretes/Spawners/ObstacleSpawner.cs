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
            poolEnemy.gameObject.SetActive(true);
        }
    }

}
