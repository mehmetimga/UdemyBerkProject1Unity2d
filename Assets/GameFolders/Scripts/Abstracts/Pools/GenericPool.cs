using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UdemyBerkProject1.Abstracts.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T:Component
    {
        [SerializeField] T[] prefabs;
        [SerializeField] int countLoop = 5;

        Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake()
        {
            SingletonObject();
        }

        private void Start()
        {
            GrowPoolPrefabs();
        }

        protected abstract void SingletonObject();

        public T Get()
        {
            if (_poolPrefabs.Count == 0)
            {
                GrowPoolPrefabs();
            }
            return _poolPrefabs.Dequeue();
        }

        private void GrowPoolPrefabs()
        {
            for(int i=0;i<countLoop;i++)
            {
                T newPrefab = Instantiate(prefabs[UnityEngine.Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }
        }

        public void Set(T poolObject)
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);

        }
    }
}

