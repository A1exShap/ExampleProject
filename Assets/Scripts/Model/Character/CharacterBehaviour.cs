using UnityEngine;


namespace ExampleTemplate
{
    public sealed class CharacterBehaviour : MonoBehaviour
    {
        private CharacterData _characterData;

        private void Awake()
        {
            _characterData = Data.Instance.Character;
        }

        public void Move(Vector3 moveDirection)
        {
            moveDirection = moveDirection.normalized;
            transform.Translate(moveDirection * _characterData.GetSpeed());
        }
    }
}
