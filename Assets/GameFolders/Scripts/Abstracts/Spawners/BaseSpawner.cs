using System;
using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Controllers;
using UdemyBerkProject1.Movements;
using UnityEngine;

namespace UdemyBerkProject1.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;

        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1;

        float _currentSpawnTime;
        float _timeBoundary;

        Mover _mover;

        private void Start()
        {
            _timeBoundary =  UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                TimeReset();
            }
        }

        private void TimeReset()
        {
            _currentSpawnTime = 0;
            _timeBoundary = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
        }

        protected abstract void Spawn();
    }
}

