using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PortalManager : MonoBehaviour
{
    public Camera MainCamera;

    public GameObject Sponza;

    private Material[] SponzaMaterials;

    public bool isColliding = false;
    // Start is called before the first frame update

    void Awake()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }
    void Start()
    {
        SponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;

    }

    void Update()
    {

    }

    // Update is called once per frame
    void OnTriggerStay (Collider collider)
    {
        isColliding = true;
        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

        if(camPositionInPortalSpace.y < 0.5)
        {
            //Disable Stencil Test
            for (int i = 0; i < SponzaMaterials.Length; ++i)
            {
                SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
            }
        }

        else
        {
            //Enable Stencil Test
            for (int i = 0; i < SponzaMaterials.Length; ++i)
            {
                SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
            }
        }
    }
}
