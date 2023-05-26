using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Controllers;
using UdemyBerkProject1.Movements;
using UnityEngine;
using UdemyBerkProject1.Abstracts.Spawners;
using UdemyBerkProject1.Pools;

namespace UdemyBerkProject1.Spawners
{

    public class RedDragonSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.gameObject.SetActive(true);
        }

    }
}

