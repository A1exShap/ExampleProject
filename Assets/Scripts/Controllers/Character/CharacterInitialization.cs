using UnityEngine;


namespace ExampleTemplate
{
    public sealed class CharacterInitialization : IInitialization
    {
        public void Initialization()
        {
            var characterBehaviour = CustomResources.Load<CharacterBehaviour>
                (AssetsPathGameObject.GameObjects[GameObjectType.Character]);

            Data.Instance.Character.CharacterBehaviour = Object.Instantiate(characterBehaviour);
        }
    }
}
