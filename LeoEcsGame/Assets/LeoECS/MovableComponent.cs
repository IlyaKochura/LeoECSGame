using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace LeoECS
{
    [Serializable]
    public struct MovableComponent
    {
        public CharacterController characterController;
        public float speed;
    }
    
}