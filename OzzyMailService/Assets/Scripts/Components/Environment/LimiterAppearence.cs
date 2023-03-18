using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OzzyMailService.Components.Environment
{
    public class LimiterAppearence : MonoBehaviour
    {
        [Header("Limiters")]
        [SerializeField] private GameObject _limiter50;
        [SerializeField] private GameObject _limiter75;
        [SerializeField] private GameObject _limiter100;


        public void UpdateVisual(int value)
        {
            _limiter50.SetActive(false);
            _limiter75.SetActive(false);
            _limiter100.SetActive(false);

            switch (value)
            {
                case 50:
                    _limiter50.SetActive(true);
                    break;
                case 75:
                    _limiter50.SetActive(true);
                    break;
                case 100:
                     _limiter50.SetActive(true);
                    break;
                default:
                    break;
            }

        }
    }

}
