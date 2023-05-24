using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyBerkProject1.Abstracts.Contollers
{
    public class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;

        float _currentLifeTime;

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;
            if (_currentLifeTime > maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

