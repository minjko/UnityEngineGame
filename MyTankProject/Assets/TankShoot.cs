using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody prefabShell;
    public Transform fireTransform;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        
    }

    void Fire()
    {
        Rigidbody shellInstance = Instantiate(prefabShell, fireTransform.position, fireTransform.rotation) as Rigidbody;
        shellInstance.velocity = 20.0f * fireTransform.forward;

    }
}
