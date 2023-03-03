using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Player;

namespace OzzyMailService.Components.Environment
{
    public class GateComponent : MonoBehaviour
    {
        [SerializeField] private GateAppearence _gateAppearence;
        [SerializeField] private DeformationType _deformationType;
        [SerializeField] private int _value;

        private void OnValidate()
        {
            _gateAppearence.UpdateVisual(_deformationType, _value);
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();

            if (playerModifier != null)
            {
                if (_deformationType == DeformationType.Width)
                {
                    playerModifier.AddWidth(_value);
                }
                else if (_deformationType == DeformationType.Height)
                {
                    playerModifier.AddHeight(_value);
                }
                Destroy(gameObject);
            }
        }
    }
}

