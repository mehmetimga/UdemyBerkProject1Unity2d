using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Pools;
using UnityEngine;

namespace UdemyBerkProject1.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}

