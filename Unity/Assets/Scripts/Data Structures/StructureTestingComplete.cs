using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureTestingComplete : MonoBehaviour
{
    const int numberOfTests = 10000;
    int[] inventory = new int[numberOfTests];
    Dictionary<int, int> inventoryD = new Dictionary<int, int>();
    List<int> inventoryL = new List<int>();
    HashSet<int> inventoryH = new HashSet<int>();

    void Start()
    {
        AddValuesInArray();
        AddValuesInDict();
        AddValuesInList();
        AddValuesInHash();
    }


    void AddValuesInArray()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            inventory[i] = Random.Range(10, 100);
        }
    }

    void IterValuesInArray()
    {
        foreach(int i in inventory)
        {
            Debug.Log(i);
        }
    }

    void ContainsValuesInArray()
    {
        int searchValue = 5000;
        foreach (int i in inventory)
        {
            if (inventory[i] == searchValue)
                return;
        }
    }

    void RemoveValuesInArray()
    {
        int index = 5000;
        int[] temp = new int[inventory.Length - 1];
        int tempCounter = 0;
        for (int i = 0; i < inventory.Length; i++)
        {
            if (i != index)
            {
                temp[tempCounter] = inventory[i];
                tempCounter++;
            }
        }
        inventory = temp;
    }

    void AddValuesInDict()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            inventoryD.Add(i, Random.Range(10, 100));
        }
    }


    void IterValuesInDict()
    {
        foreach (KeyValuePair<int,int> i in inventoryD)
        {
            Debug.Log(i.Value);
        }
    }

    void ContainsValuesInDict()
    {
        int searchValue = 5000;
        bool found = inventoryD.ContainsKey(searchValue);
    }

    void RemoveValuesInDict()
    {
        int searchValue = 5000;
        bool found = inventoryD.Remove(searchValue);
    }

    void AddValuesInList()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            inventoryL.Add(Random.Range(10, 100));
        }
    }

    void IterValuesInList()
    {
        foreach (int i in inventoryL)
        {
            Debug.Log(inventoryL[i]);
        }
    }

    void ContainsValuesInList()
    {
        int searchValue = 5000;
        bool found = inventoryL.Contains(searchValue);
    }

    void RemoveValuesInList()
    {
        int searchValue = 5000;
        bool found = inventoryL.Remove(searchValue);
    }

    void AddValuesInHash()
    {
        for (int i = 0; i < numberOfTests; i++)
        {
            inventoryH.Add(Random.Range(10, 100));
        }
    }

    void IterValuesInHash()
    {
        foreach (int i in inventoryH)
        {
            Debug.Log(i);
        }
    }

    void ContainsValuesInHash()
    {
        int searchValue = 5000;
        bool found = inventoryH.Contains(searchValue);
    }

    void RemoveValuesInHash()
    {
        int searchValue = 5000;
        bool found = inventoryH.Remove(searchValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IterValuesInArray();
            IterValuesInDict();
            IterValuesInList();
            IterValuesInHash();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ContainsValuesInArray();
            ContainsValuesInDict();
            ContainsValuesInList();
            ContainsValuesInHash();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            RemoveValuesInArray();
            RemoveValuesInDict();
            RemoveValuesInList();
            RemoveValuesInHash();
        }

    }
}
