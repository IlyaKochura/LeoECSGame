using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace LeoECS
{
    [Serializable]
    public struct MovableComponent
    {
        public Rigidbody characterController;
        public float speed;
        public float gravityScale;
        public Vector3 velocity;
    }
    
}