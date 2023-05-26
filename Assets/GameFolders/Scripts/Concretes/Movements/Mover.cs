using System.Collections;
using System.Collections.Generic;
using UdemyBerkProject1.Enums;
using UnityEngine;
namespace UdemyBerkProject1.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;

        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void OnEnable()
        {
            _rigidbody2D.velocity = SelectNewDirection() * moveSpeed;
        }

        private Vector2 SelectNewDirection()
        {
            
            if (direction == DirectionEnum.Left)
            {
                return Vector2.left;
            }
            else
            {
                return Vector2.right;
            }
        }
    }
}

