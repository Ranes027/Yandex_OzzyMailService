using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Player;

namespace OzzyMailService.Components.Environment
{
    public class LimiterComponent : MonoBehaviour
    {
        [SerializeField] private LimiterAppearence _limiterAppearence;

        [SerializeField] private int _limitHeight;

        private void OnValidate()
        {
            _limiterAppearence.UpdateVisual(_limitHeight);
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

            if (playerModifier != null)
            {
                playerModifier.HitLimiter(_limitHeight);
            }
        }
    }

}
