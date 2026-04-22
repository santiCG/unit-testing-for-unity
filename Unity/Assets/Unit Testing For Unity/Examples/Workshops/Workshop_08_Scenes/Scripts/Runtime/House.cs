using UnityEngine;

namespace RMC.UnitTesting.Examples.Prefabs
{
    [RequireComponent(typeof(Rigidbody))]
    public class House : MonoBehaviour
    {
        [SerializeField] 
        public Rigidbody Rigidbody;

        private void Awake()
        {

        }

        private void Update()
        {
            
        }
    }
}

