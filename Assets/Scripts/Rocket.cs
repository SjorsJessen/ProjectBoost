using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private AudioSource _audioSource;

    [SerializeField] private float rcsThrust = 100f;
    protected float TestValue = 250f;

    protected void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        ThrustRocket();
        Rotate();
    }

    private void Rotate()
    {
        _rigidbody.freezeRotation = true; //Take manual control of rotation

        float rotationPerFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {          
            transform.Rotate(Vector3.forward * rotationPerFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationPerFrame);
        }

        _rigidbody.freezeRotation = false; //Resume regular rotation physics 
    }

    private void ThrustRocket()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddRelativeForce(Vector3.up);

            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }
        else
        {
            _audioSource.Stop();
        }
    }

    public void FireProjectile()
    {
        Debug.Log("Fire at same speed");
    }
}
