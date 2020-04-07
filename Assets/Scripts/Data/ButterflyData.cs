using UnityEngine;


namespace ExampleTemplate
{
    [CreateAssetMenu(fileName = "ButterflyData", menuName = "Data/NPC/ButterflyData")]
    public sealed class ButterflyData : ScriptableObject
    {
        [SerializeField] private float _speed = 4.0f;
        [SerializeField] private float _stopingDistance = 2.0f;

        [HideInInspector] public ButterflyBehaviour ButterflyBehaviour;

        private ITimeService _timeService;

        private void OnEnable()
        {
            _timeService = Services.Instance.TimeService;
        }

        public float GetSpeed()
        {
            return _speed * _timeService.DeltaTime();
        }

        public float GetStopingDistance()
        {
            return _stopingDistance;
        }
    }
}