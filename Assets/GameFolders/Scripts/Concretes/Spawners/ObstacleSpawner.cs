using UnityEngine;
using UdemyBerkProject1.Controllers;
using UdemyBerkProject1.Abstracts.Spawners;

namespace UdemyBerkProject1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {

        [SerializeField] EnemyController[] enemies;


        protected override void Spawn()
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, transform.rotation);
        }
    }

}
