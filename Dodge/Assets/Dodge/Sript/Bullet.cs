﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public int m_speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * m_speed * Time.deltaTime;

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(transform.forward * 1.2f);
    }
}