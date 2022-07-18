using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    sealed class GravitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<ModelComponent, MovableComponent> _ecsFilter = null;
        
        public void Run()
        {
            foreach (var i in _ecsFilter)
            {
                ref var model = ref _ecsFilter.Get1(i);
                ref var move = ref _ecsFilter.Get2(i);

                var characterController = move.characterController;
                var gMove = new Vector3(0, Time.deltaTime * move.gravityScale, 0);
                characterController.transform.position -= gMove;

            }
            
        }
    }
}