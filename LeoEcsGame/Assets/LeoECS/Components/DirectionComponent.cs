using System;
using UnityEngine;

namespace LeoECS
{
    [Serializable]
    public struct DirectionComponent
    {
        [HideInInspector] public Vector3 direction;
    }
}