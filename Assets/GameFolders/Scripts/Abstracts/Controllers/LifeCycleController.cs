using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyBerkProject1.Abstracts.Contollers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;

        protected float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                KillGameObject();
            }
        }

        public abstract void KillGameObject();
    }
}

