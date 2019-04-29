using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Laser laser;

    // Start is called before the first frame update
    void Start()
    {
        laser = FindObjectOfType<Laser>();
    }

    private void FireGun()
    {
        laser.FireProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
