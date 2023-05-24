using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyBerkProject1.Movements;
using UdemyBerkProject1.Combats;

namespace UdemyBerkProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private bool _isLeftMouseClicked;
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
        LaunhProjectile _launchProjectile;
        AudioSource _audioSource;
        void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunhProjectile>();

            _input = new PcInputController();
            _audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;

            }
            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();

            }
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked = false;
            }
            
        }
    }
}

