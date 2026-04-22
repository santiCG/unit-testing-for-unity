using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public GameObject spawnPos;
    public GameObject player;
    AudioSource gunSound;
    float shootCoolDown = 0;
    private float disableDistance = 5f;

    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        gunSound = this.GetComponent<AudioSource>();
        StartCoroutine(DistanceDisable());
	}

    #region  Disabling Scripts By Visibility
    /*private void OnBecameVisible()
    {
        enabled = true;
    }

    private void OnBecameInvisible()
    {
        enabled = false;
    }*/
    #endregion

    #region Disabling Scripts By Distance

    IEnumerator DistanceDisable()
    {
        while (true)
        {
            float distance = Vector3.Distance(player.transform.position, this.transform.position);
            if (distance <= disableDistance * disableDistance)
            {
                enabled = true;
            }
            else
            {
                enabled = false;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    #endregion

    void ShootBullet()
    {
        Instantiate(bullet, spawnPos.transform.position, spawnPos.transform.rotation);
        gunSound.Play();
    }

    float turnSpeed = 1.0f;
	// Update is called once per frame
	void Update () {

        if(player)
        {
            Vector3 direction = player.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                Quaternion.LookRotation(direction),
                                turnSpeed * Time.smoothDeltaTime);
            if (shootCoolDown <= 0)
            {
                ShootBullet();
                shootCoolDown = Random.Range(3,5);
            }
            else
                shootCoolDown -= 0.1f;
        }
	}
}
