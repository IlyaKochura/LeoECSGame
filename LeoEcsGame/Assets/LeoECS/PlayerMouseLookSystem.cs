using Leopotam.Ecs;
using UnityEngine;

namespace LeoECS
{
    sealed class PlayerMouseLookSystem : IEcsRunSystem, IEcsInitSystem
    {

        private readonly EcsFilter<PlayerTag, ModelComponent, MouseLookDirectionComponent> _mouseLookFilter = null;
        private Quaternion _startTransformRotation;
        
        public void Init()
        {
            _startTransformRotation = _mouseLookFilter.GetEntity(0).Get<ModelComponent>().ModelTransform.rotation;
        }
        
        public void Run()
        {
            foreach (var i in _mouseLookFilter)
            {
                ref var model = ref _mouseLookFilter.Get2(i);
                ref var lookComponent = ref _mouseLookFilter.Get3(i);

                var axisX = lookComponent.direction.x;
                var axisY = lookComponent.direction.y;

                var rotateX = Quaternion.AngleAxis(axisX, Vector3.up * Time.deltaTime * lookComponent.mouseSens);
                var rotateY = Quaternion.AngleAxis(axisY, Vector3.right * Time.deltaTime * lookComponent.mouseSens);

                model.ModelTransform.rotation = _startTransformRotation * rotateX;
                lookComponent.lookCamera.rotation = model.ModelTransform.rotation * rotateY;
            }
            
        }
    }
}