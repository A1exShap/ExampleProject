using UnityEngine;


namespace ExampleTemplate
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Data/Character/CharacterData")]
    public sealed class CharacterData : ScriptableObject
    {
        [SerializeField] private float _speed;

        [HideInInspector] public CharacterBehaviour CharacterBehaviour;

        private ITimeService _timeService;

        private void OnEnable()
        {
            _timeService = Services.Instance.TimeService;
        }        

        public float GetSpeed()
        {
            return _speed * _timeService.DeltaTime();
        }
    }
}