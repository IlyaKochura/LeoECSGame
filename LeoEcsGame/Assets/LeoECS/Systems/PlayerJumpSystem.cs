using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    sealed class PlayerJumpSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag,GroundCheckSphereComponent,JumpComponent, JumpEvent> jumpfilter = null;

        public void Run()
        {
            foreach (var i in jumpfilter)
            {
                ref var entity = ref jumpfilter.GetEntity(i);
                ref var groundCheck = ref jumpfilter.Get2(i);
                ref var jumpComponent = ref jumpfilter.Get3(i);
                ref var movable = ref entity.Get<MovableComponent>();
                ref var velocity = ref movable.velocity;
                
                if (!groundCheck.isGrounded) continue;

                velocity.y = Mathf.Sqrt(jumpComponent.jumpScale* -2f * movable.gravityScale);
               
            }
        }
    }
}