using System.Collections.Generic;


namespace ExampleTemplate
{
    public sealed class MovingController : IExecute
    {
        #region Fields

        private readonly List<IMovable> _movableObjects;

        #endregion


        #region ClassLifeCycles

        public MovingController()
        {
            _movableObjects = MoveExtension.MovableObjectsList;
        }

        #endregion


        #region IExecute

        public void Execute()
        {
            for (int i = 0; i < _movableObjects.Count; i++)
            {
                _movableObjects[i].Move();
            }
        }

        #endregion
    }
}
