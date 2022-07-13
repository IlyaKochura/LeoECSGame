using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    public class InputSystem : IEcsRunSystem
    {
        private readonly EcsFilter< PlayerTag, DirectionComponent> directionFilter = null;

        private float _moveX;
        private float _moveZ;
        
        public void Run()
        {
            SetDirection();
            
            foreach (var i in directionFilter)
            {
                ref var directionComponent = ref directionFilter.Get2(i);
                ref var direction = ref directionComponent.Direction;

                direction.x = _moveX;
                direction.z = _moveZ;
            }
        }

        private void SetDirection()
        {
            _moveX = Input.GetAxis("Horizontal");
            _moveZ = Input.GetAxis("Vertical");
        }
    }
}