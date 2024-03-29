using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OzzyMailService.Components.GameObjectBased
{
    public class PointMovingComponent : MonoBehaviour
    {
        [SerializeField] private float _speed = 1f;
        [Header("Points Settings")]
        [SerializeField] private int _startingPoint;
        [SerializeField] private Transform[] _points;

        private int i;

        private void Start()
        {
            transform.position = _points[_startingPoint].position;
        }

        private void Update()
        {
            if (Vector2.Distance(transform.position, _points[i].position) < 0.02f)
            {
                i++;
                if (i == _points.Length)
                {
                    i = 0;
                }
            }

            transform.position = Vector2.MoveTowards(transform.position, _points[i].position, _speed * Time.deltaTime);
        }
    }
}

