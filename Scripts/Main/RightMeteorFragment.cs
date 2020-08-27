﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMeteorFragment : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8);
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * 45 * Time.deltaTime, Space.World);

        transform.Translate(new Vector3(0.01f, 1 * Time.deltaTime), Space.World);

    }

}
