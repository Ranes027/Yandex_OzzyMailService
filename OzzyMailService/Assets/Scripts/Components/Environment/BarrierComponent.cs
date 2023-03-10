using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Player;

namespace OzzyMailService.Components.Environment
{
    public class BarrierComponent : MonoBehaviour
    {
        [SerializeField] int _barrierDamage;

        [SerializeField] GameObject _breakEffectPrefab;

        private void OnTriggerEnter(Collider other)
        {
            PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

            if (playerModifier != null)
            {
                playerModifier.HitBarrier(_barrierDamage);
                Destroy(gameObject);

                Instantiate(_breakEffectPrefab, transform.position, transform.rotation);
            }
        }
    }
}

