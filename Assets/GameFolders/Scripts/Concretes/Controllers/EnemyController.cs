using System;
using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Abstracts.Contollers;
using UdemyBerkProject1.Pools;
using UnityEngine;
namespace UdemyBerkProject1.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentLifeTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
        
    }
}

