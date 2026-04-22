using System;
using System.Diagnostics.CodeAnalysis;
using RMC.UnitTesting.Examples.Prefabs;
using UnityEngine;

namespace RMC.UnitTesting.Examples.Scenes
{
    /// <summary>
    /// This example is the main entry point for the
    /// Scene Loading demonstration
    /// </summary>
    public class Scene03_House: MonoBehaviour
    {
        [SerializeField] 
        private House _house;
        
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {_house.name}");

            //Uncomment Exception to see a failing test
            //throw new Exception("Something wrong happens :)");
        }

    }
}