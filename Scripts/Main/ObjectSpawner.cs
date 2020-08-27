using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Portal;
    private PlacementIndicator placementIndicator;
    public bool HasSpawned = false;
    public GameObject ARCamera;
    public ARRaycastManager rayManager;


    void Start()
    {
        rayManager = FindObjectOfType<ARRaycastManager>();
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update()
    {
        //for Testing on Unity Editor

        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && !HasSpawned && rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), placementIndicator.get_Array(), TrackableType.Planes))

        if (Input.GetKeyDown(KeyCode.Space) && !HasSpawned)

        {
            
            HasSpawned = true;
            GameObject obj = Instantiate(Portal, placementIndicator.transform.position, placementIndicator.transform.rotation);

            Vector3 cameraPosition = ARCamera.transform.position;

            cameraPosition.y = placementIndicator.transform.position.y;

            obj.transform.LookAt(cameraPosition, Portal.transform.up);


        }
    }
}
