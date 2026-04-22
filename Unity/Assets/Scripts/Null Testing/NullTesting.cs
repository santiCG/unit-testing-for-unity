using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullTesting : MonoBehaviour
{
    const int numberOfTests = 55000;
    GameObject _testObj;

    void PerformComparison1()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            if (_testObj != null)
            {
                
            }
        }
    }

    void PerformComparison2()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            if (_testObj is not null)
            {
                
            }
        }
    }

    void PerformComparison3()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            if (!ReferenceEquals(_testObj, null))
            {
                
            }
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PerformComparison1();
            PerformComparison2();
            PerformComparison3();
        }
    }
}
