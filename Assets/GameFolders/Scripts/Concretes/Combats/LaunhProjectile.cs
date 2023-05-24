using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Controllers;
using UnityEngine;

namespace UdemyBerkProject1.Combats
{
    public class LaunhProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 1f;
        float _currentDelayTime = 0f;
        bool _canLaunch = false;
        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }
        public void LaunchAction()
        {
            if (_canLaunch)
            {
                ProjectileController newProjectile =  Instantiate
                    (projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);
                newProjectile.transform.parent = projectileParent.transform;

                _canLaunch = false;
            }
        }
    }
}

