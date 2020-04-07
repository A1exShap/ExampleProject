using UnityEngine;


namespace ExampleTemplate
{
    public sealed class ButterflyBehaviour : MonoBehaviour, IMovable
    {
        #region Fields

        private ButterflyData _butterflyData;
        private Transform _targetTransform;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _butterflyData = Data.Instance.Butterfly;
        }

        private void OnEnable()
        {
            this.AddMovableObject();
        }

        private void OnDisable()
        {
            this.RemoveMovableObject();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag(TagManager.GetTag(TagType.Player)))
            {
                SetMoveTarget(other.transform);
            }
        }

        #endregion


        #region Methods

        public void Move()
        {
            var stopingDistance = _butterflyData.GetStopingDistance();
            stopingDistance *= stopingDistance;

            if (_targetTransform != null)
            {
                if (Vector3.SqrMagnitude(transform.position - _targetTransform.position) > stopingDistance)
                {
                    var moveDirection = _targetTransform.position - transform.position;
                    moveDirection = moveDirection.normalized;
                    transform.Translate(moveDirection * _butterflyData.GetSpeed());
                }
            }
        }

        public void SetMoveTarget(Transform moveDirection)
        {
            _targetTransform = moveDirection;
        }

        #endregion
    }
}
