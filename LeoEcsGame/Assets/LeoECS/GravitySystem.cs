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

                var direction = model.ModelTransform.position;
                direction.y -= Time.deltaTime * move.gravityScale;
                
            }
            
        }
    }
}