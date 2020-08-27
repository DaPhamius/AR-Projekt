using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;
    public float turnSpeed;
    [SerializeField]
    private float curSpeed;
    public float reverseAcceleration;
    public float reverseMaxSpeed;
    private float curReverseSpeed;
    private float moveSpeed;

    public bool doAccelerate;
    public bool doReverse;

    private Rigidbody rig;

    // instance
    public static Car instance;

    private void Awake()
    {
        instance = this;
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Accelerate();
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void Turn(float rate)
    {
        transform.Rotate(Vector3.up, rate * turnSpeed * Time.deltaTime);
    }

    public void Accelerate()
    {

        if (doAccelerate)
        {
            curSpeed = Mathf.Clamp(curSpeed + (Time.deltaTime * acceleration), 0.0f, maxSpeed);
            rig.velocity = transform.forward * curSpeed;
        }

        else if (doReverse)
        {
            curReverseSpeed = Mathf.Clamp(curReverseSpeed + (Time.deltaTime * reverseAcceleration), 0.0f, reverseMaxSpeed);
            rig.velocity = -transform.forward * curReverseSpeed;
        }

        else
        {
            if (curSpeed > 0)
            {
                curSpeed = Mathf.Clamp(curSpeed - (Time.deltaTime * acceleration), 0.0f, maxSpeed);
                rig.velocity = transform.forward * curSpeed;
            }

            if (curReverseSpeed > 0)
            {
                curReverseSpeed = Mathf.Clamp(curReverseSpeed - (Time.deltaTime * acceleration), 0.0f, maxSpeed);
                rig.velocity = -transform.forward * curReverseSpeed;
            }
        }
    }
}
