using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Pools;
using UnityEngine;
namespace UdemyBerkProject1.Controllers
{
    public class ObstacleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObstaclePool.Instance.Set(this);
        }
    }
}

