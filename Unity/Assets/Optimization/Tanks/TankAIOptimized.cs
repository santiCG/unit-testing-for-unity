using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TankAIOptimized : MonoBehaviour
{
    public int numberOfTanks;
    public GameObject tankPrefab;
    private Transform[] _tanks;
    private Transform _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _tanks = new Transform[numberOfTanks];
    }

    private void Start()
    {
        GameObject tank;
        for (int i = 0; i < numberOfTanks; i++)
        {
            tank = Instantiate(tankPrefab);
            tank.transform.position = new Vector3(Random.Range(-50,50), 0, Random.Range(-50,50));
            _tanks[i] = tank.transform;
        }
        
        StartCoroutine("FollowPlayer");
    }

    private IEnumerator FollowPlayer()
    {
        while (true)
        {
            foreach (Transform t in _tanks)
            {
                t.LookAt(_player.position);
            }
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void Update()
    {
        foreach (Transform t in _tanks)
        {
            t.Translate(0, 0, 0.01f);
        }
    }
}
