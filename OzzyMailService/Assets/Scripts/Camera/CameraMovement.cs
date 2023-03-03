using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OzzyMailService.CameraMovement
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        private void Start()
        {
            transform.parent = null;
        }

        private void LateUpdate()
        {
            if (_target != null)
            {
                transform.position = new Vector3(0, 0, _target.position.z);
            }
        }
    }
}

