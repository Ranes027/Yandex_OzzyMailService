using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OzzyMailService.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Player Settings")]
        [SerializeField] private float _speed;
        [SerializeField] private Animator _animator;

        [Header("Limiters")]
        [SerializeField] private float _roadWidth;
        [SerializeField] private float _rotationAngle = 50f;

        private float _oldMousePositionX;
        private float _eulerY;

        private void Update()
        {
            Run();

            if (Input.GetMouseButtonDown(0))
            {
                _oldMousePositionX = Input.mousePosition.x;
            }

            if (Input.GetMouseButton(0))
            {
                float deltaX = Input.mousePosition.x - _oldMousePositionX;
                _oldMousePositionX = Input.mousePosition.x;

                _eulerY += deltaX;
                _eulerY = Mathf.Clamp(_eulerY, -_rotationAngle, _rotationAngle);
                transform.eulerAngles = new Vector3(0, _eulerY, 0);
            }
        }

        private void Run()
        {
            _animator.SetBool("Run", true);
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -_roadWidth, _roadWidth);
            transform.position = newPosition;
        }
    }
}

