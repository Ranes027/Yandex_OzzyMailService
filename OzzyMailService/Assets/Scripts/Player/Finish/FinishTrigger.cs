using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Data;

namespace OzzyMailService.Player
{
    public class FinishTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
            if (playerBehaviour != null)
            {
                playerBehaviour.StartFinishBehaviour();

                FindObjectOfType<GameManager>().ShowFinishWindow();
            }
        }
    }

}
