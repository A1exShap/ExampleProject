using UnityEngine;


namespace ExampleTemplate
{
    public sealed class NPCInitialize : IInitialization
    {
        public void Initialization()
        {
            var buterflyBehaviour = CustomResources.Load<ButterflyBehaviour>
                (AssetsPathGameObject.GameObjects[GameObjectType.Butterfly]);

            Object.Instantiate(buterflyBehaviour);
        }
    }
}
