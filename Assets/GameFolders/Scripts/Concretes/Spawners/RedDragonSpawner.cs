using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Controllers;
using UdemyBerkProject1.Movements;
using UnityEngine;
using UdemyBerkProject1.Abstracts.Spawners;

namespace UdemyBerkProject1.Spawners
{

    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }

    }
}

