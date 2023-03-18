using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OzzyMailService.Player
{
    public class PlayerModifier : MonoBehaviour
    {
        [Header("Modifier Stats")]
        [SerializeField] private int _width;
        [SerializeField] private int _height;

        [Header("Objects to modify")]
        [SerializeField] private Renderer _renderer;

        [SerializeField] private Transform _topSpine;
        [SerializeField] private Transform _bottomSpine;
        [SerializeField] private Transform _colliderTransform;

        private float _widthMultiplier = 0.0005f;
        private float _heightMultiplier = 0.01f;

        public void AddWidth(int value)
        {
            _width += value;
            UpdateWidth();
        }

        public void SetWidth(int value)
        {
            _width = value;
            UpdateWidth();
        }

        private void UpdateWidth()
        {
            _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
        }

        public void AddHeight(int value)
        {
            _height += value;
            UpdateHeight();
        }

        public void SetHeight(int value)
        {
            _height = value;
            UpdateHeight();
        }

        private void UpdateHeight()
        {
            float offsetY = _height * _heightMultiplier + 0.17f;
            _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
            _colliderTransform.localScale = new Vector3(1, 1.85f + _height * _heightMultiplier, 1);
        }

        public void HitBarrier(int value)
        {
            if (_height > 0)
            {
                _height -= value;
                UpdateHeight();
            }
            else if (_width > 0)
            {
                _width -= value;
                UpdateWidth();
            }
            else
            {
                Die();
            }
        }

        public void HitLimiter(int value)
        {
            if (_height > value)
            {
                SetHeight(value);
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}

