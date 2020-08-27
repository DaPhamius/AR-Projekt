using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;

    public float projectileSpeed;
    public float shootRate;
    private float lastShootTime;

    public static Shooting instance;
    private Camera cam;

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        AnimationElevator elevatorTarget = GameObject.FindGameObjectWithTag("Elevator").GetComponent<AnimationElevator>();

        if (elevatorTarget.encounter_meteors == true && Input.GetKeyDown(KeyCode.Space))
        //if (elevatorTarget.encounter_meteors == true && Input.touchCount > 0)
        {
            if (Time.time - lastShootTime >= shootRate)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        lastShootTime = Time.time;

        GameObject proj = Instantiate(projectilePrefab, cam.transform.position, Quaternion.identity);

        proj.GetComponent<Rigidbody>().velocity = cam.transform.forward * projectileSpeed;
        Destroy(proj, 3.0f);
    }

}
