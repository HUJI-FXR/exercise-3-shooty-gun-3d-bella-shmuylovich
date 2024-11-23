using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject spawnTransform;
    [SerializeField] private float bulletSpeed;

    #endregion

    #region MONOBEHAVIOUR

    private void Update()
    {
        CheckInput();
    }

    #endregion

    #region HELPERS

    private void CheckInput()
    {
        if (Input.GetMouseButtonUp(0)) Shoot();
    }

    private void Shoot()
    {
        GameObject shot = Instantiate(bullet, spawnTransform.transform.position, spawnTransform.transform.rotation);
        shot.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed * Time.deltaTime;
        Destroy(shot, 5f);
    }

    #endregion
}
