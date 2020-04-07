using UnityEngine;
using System.Collections.Generic;


namespace ExampleTemplate
{
    public static partial class MoveExtension
    {

        #region Fields

        private static readonly List<IMovable> _movableObjectsList = new List<IMovable>(10);

        #endregion


        #region Properties

        public static List<IMovable> MovableObjectsList => _movableObjectsList;

        #endregion


        #region Methods

        public static void AddMovableObject(this IMovable value)
        {
            if (_movableObjectsList.Contains(value))
            {
                return;
            }
           
            _movableObjectsList.Add(value);
        }

        public static void RemoveMovableObject(this IMovable value)
        {
            if (!_movableObjectsList.Contains(value))
            {
                return;
            }
            _movableObjectsList.Remove(value);
        }

        #endregion
    }
}
