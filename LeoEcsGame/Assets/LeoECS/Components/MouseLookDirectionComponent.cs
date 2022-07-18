using System;
using UnityEngine;

namespace LeoECS
{
    [Serializable]
    public struct MouseLookDirectionComponent
    {
        public float mouseSens;
        public Transform lookTransform;
        public Transform lookCamera;
        public Vector3 direction;
    }
}