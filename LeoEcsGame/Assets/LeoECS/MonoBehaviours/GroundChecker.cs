using System;
using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS.MonoBehaviours
{
    sealed class GroundChecker : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                
            }
        }
    }
}