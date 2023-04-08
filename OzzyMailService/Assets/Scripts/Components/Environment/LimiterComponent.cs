using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Player;

namespace OzzyMailService.Components.Environment
{
    public class LimiterComponent : MonoBehaviour
    {
        [SerializeField] private LimiterAppearence _limiterAppearence;

        [SerializeField] private Limiters _limitHeight;

        private void OnValidate()
        {
            _limiterAppearence.UpdateVisual((int)_limitHeight);
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

            if (playerModifier != null)
            {
                playerModifier.HitLimiter((int)_limitHeight);
            }
        }
    }

    public enum Limiters
    {
        Limiter50 = 50,
        Limiter75 = 75,
        Limiter100 = 100
    }

}
