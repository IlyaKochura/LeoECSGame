using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    public class MouseInputSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag, MouseLookDirectionComponent> _playerFilter = null;

        private float axisX;
        private float axisY;

        public void Run()
        {
            GetAxis();

            foreach (var i in _playerFilter)
            {
                ref var lookComponent = ref _playerFilter.Get2(i);

                lookComponent.direction.x = axisX;
                lookComponent.direction.y = axisY;
            }
        }

        private void GetAxis()
        {
            axisX += Input.GetAxis("Mouse X");
            axisY -= Input.GetAxis("Mouse Y");
        }
        
    }
}