using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] KeyCode shoot = KeyCode.Mouse0;
    public Transform FirePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);

    }
}

