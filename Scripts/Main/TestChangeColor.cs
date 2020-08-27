using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeColor : MonoBehaviour
{
    public GameObject sickBloodcell1;
    public GameObject sickBloodcell2;
    public GameObject sickBloodcell3;
    public Material red;
    public Color color;

    // Use this for initialization
    void Start()
    {
        // apply the same mnaterial to the both of the GameObject
        sickBloodcell1.GetComponent<MeshRenderer>().material = red;
        sickBloodcell2.GetComponent<MeshRenderer>().material = red;
        sickBloodcell3.GetComponent<MeshRenderer>().material = red;

    }

    // Update is called once per frame
    void Update()
    {
        // change to sharedMaterial property of one renderer will reflect 
        // on other GameObject also
        sickBloodcell1.GetComponent<MeshRenderer>().material.color = color;
    }
}
