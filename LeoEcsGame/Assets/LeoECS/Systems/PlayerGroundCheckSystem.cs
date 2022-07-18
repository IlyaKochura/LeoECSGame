using Leopotam.Ecs;

namespace LeoECS
{
    public class PlayerGroundCheckSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag, GroundCheckSphereComponent> groundFilter = null;

        public void Run()
        {
            foreach (var i in groundFilter)
            {
                ref var grondCheck = ref groundFilter.Get2(i);
                
                
            }
        }
    }
}