
using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.UnitTesting.Examples.CharacterBasic
{
    /// <summary>
    /// This character allows simple movement
    ///
    /// NOTE: This 'basic' version uses one main class
    /// that combines MonoBehavior logic with non-MonoBehaviour
    /// logic. RESULT: This is LESS testable than the 'advanced' version.
    /// </summary>
    public class CharacterBasic : MonoBehaviour
    {
        public float Speed { get { return _speed;}}
        private const float _speed = 0.5f;

        public enum MoveType
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum RotateType
        {
            Left,
            Right
        }
        
        protected void Update()
        {
            MoveByInput();
            RotateByInput();
        }
        
        public void MoveByInput()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) ||
                Input.GetKeyDown(KeyCode.A))
            {
                MoveByKeyCode(MoveType.Left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) ||
                Input.GetKeyDown(KeyCode.D))
            {
                MoveByKeyCode(MoveType.Right);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) ||
                Input.GetKeyDown(KeyCode.W))
            {
                MoveByKeyCode(MoveType.Up);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) ||
                Input.GetKeyDown(KeyCode.S))
            {
                MoveByKeyCode(MoveType.Down);
            }
        }

        public void RotateByInput()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                RotateByKeyCode(RotateType.Left);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                RotateByKeyCode(RotateType.Right);
            }
        }

        public Vector3 MoveByKeyCode(MoveType moveType)
        {
            switch (moveType)
            {
                case MoveType.Left:
                    MoveBy(new Vector3(-_speed, 0, 0));
                    break;
                case MoveType.Right:
                    MoveBy(new Vector3(_speed, 0, 0));
                    break;
                case MoveType.Up:
                    MoveBy(new Vector3(0, _speed, 0));
                    break;
                case MoveType.Down:
                    MoveBy(new Vector3(0,  -_speed, 0));
                    break;
                default:
                    break;
            }

            return transform.position;
        }

        public Vector3 RotateByKeyCode(RotateType rotateType)
        {
            switch (rotateType)
            {
                case RotateType.Left:
                    RotateBy(20);
                    break;
                case RotateType.Right:
                    RotateBy(-20);
                    break;
                default:
                    break;
            }
            
            return transform.rotation.eulerAngles;
        }
        
        public Vector3 MoveTo (Vector3 position)
        {
            transform.position = position;
            return transform.position;
        }

        public Vector3 MoveBy (Vector3 position)
        {
            transform.position += position;
            return transform.position;
        }

        public Vector3 RotateBy(float degrees)
        {
            transform.Rotate(Vector3.up, degrees);
            return transform.rotation.eulerAngles;
        }
    }
}