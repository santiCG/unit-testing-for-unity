using NUnit.Framework;
using UnityEditor;
using UnityEngine;


namespace RMC.UnitTesting.Examples.Prefabs
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.Prefabs")]
    public class PrefabPlayModeTest
    {
        private const float DelayForSetupTime = 0.5f;
        private const string EnemyPrefabPath = 
            "Assets/Unit Testing For Unity/Examples/Workshops/Workshop_07_Prefabs/Scripts/Prefabs/Enemy.prefab";
        private const string HousePrefabPath = 
            "Assets/Unit Testing For Unity/Examples/Workshops/Workshop_07_Prefabs/Scripts/Prefabs/House.prefab";

        private Enemy _enemy;
        private House _house;

        /// <summary>
        /// Setup method to initialize the test environment before each test is run
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(EnemyPrefabPath);
            
            // Instantiate the prefab
            _enemy = GameObject.Instantiate(prefab, new Vector3(0, 0, 10), new Quaternion(0, 180, 0, 0)).GetComponent<Enemy>();
            
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab2 = AssetDatabase.LoadAssetAtPath<GameObject>(HousePrefabPath);
            
            // Instantiate the prefab
            _house = GameObject.Instantiate(prefab2, new Vector3(0, 0, 10), new Quaternion(0, 180, 0, 0)).GetComponent<House>();
            
            // Wait for three seconds (Arbitrary time for prefab to set up itself).
            while (Time.realtimeSinceStartup < DelayForSetupTime)
            {
                // Wait
            }
        }

        /// <summary>
        /// Teardown method to clean up the test environment after each test has run
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (_enemy != null || _house != null)
            {
                Object.DestroyImmediate(_enemy.gameObject);
                Object.DestroyImmediate(_house.gameObject);
                _enemy = null;
                _house = null;
            }
        }

        [Test]
        public void PrefabsAreNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy, Is.Not.Null);
            Assert.That(_house, Is.Not.Null);
        }
        
        [Test]
        public void PrefabsGameObjsAreNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy.gameObject, Is.Not.Null);
            Assert.That(_house.gameObject, Is.Not.Null);
        }
        
        [Test]
        public void PrefabsRigidbodiesAreNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy.Rigidbody, Is.Not.Null);
            Assert.That(_house.Rigidbody, Is.Not.Null);
        }

    }
}