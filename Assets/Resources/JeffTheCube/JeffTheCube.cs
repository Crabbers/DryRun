﻿using UnityEngine;
using System.Collections;
using SomeLibrary;

public class JeffTheCube : MonoBehaviour
{
    public float _moveSpeed = 5f;

    private SomeClass _someClass = new SomeClass();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();

        if(Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }

        transform.position += movement.normalized * _moveSpeed * Time.deltaTime * _someClass.Random();

    }
}
