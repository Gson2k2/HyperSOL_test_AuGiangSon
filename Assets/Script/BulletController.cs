using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject,0.5f);
    }

    private void Update()
    {
        _rigidbody2D.AddForce(transform.up * 0.5f,ForceMode2D.Impulse);
    }
}
