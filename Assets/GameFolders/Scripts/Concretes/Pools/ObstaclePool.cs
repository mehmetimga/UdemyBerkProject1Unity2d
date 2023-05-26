using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Abstracts.Pools;
using UdemyBerkProject1.Controllers;
using UnityEngine;

namespace UdemyBerkProject1.Pools
{
    public class ObstaclePool : GenericPool<EnemyController>
    {
        public static ObstaclePool Instance { get; private set; }
        protected override void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
