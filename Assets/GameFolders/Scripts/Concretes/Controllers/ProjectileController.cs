using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Abstracts.Contollers;
using UnityEngine;

namespace UdemyBerkProject1.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();
            if (enemy != null)
            {
                GameManager.Instance.IncreaseScore();
                enemy.KillGameObject();
            }
            KillGameObject();
        }
    }
}

