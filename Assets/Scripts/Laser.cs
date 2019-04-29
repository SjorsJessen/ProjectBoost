using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Rocket
{

    void Update()
    {
        FireRocket();
    }

    private void FireRocket()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FireProjectile();
            Debug.Log("TestValue: " + TestValue);
        }
    }
}
