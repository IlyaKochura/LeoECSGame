using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    sealed class CursorLockInit : IEcsInitSystem
    {
        public void Init()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}