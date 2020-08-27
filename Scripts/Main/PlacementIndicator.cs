using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager rayManager;
    public GameObject visual;
    public ObjectSpawner objectSpawner;
    public ARPlaneManager ar_PlaneManager;


    void Start ()
    {
        // get the components
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;
        objectSpawner = FindObjectOfType<ObjectSpawner>();
        ar_PlaneManager = FindObjectOfType<ARPlaneManager>();

        // hide the placement visual
        visual.SetActive(false);
    }

    void Update ()
    {

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        hits = get_Array();

        if (!objectSpawner.HasSpawned)
        {
            if (hits.Count > 0)
            {
                // if we hit an AR plane, update the position and rotation

                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;

                if (!visual.activeInHierarchy)
                    visual.SetActive(true);
            }
        }

        if (objectSpawner.HasSpawned == true)
        {
            visual.SetActive(false);
            foreach (var plane in ar_PlaneManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }
        }

    }

    // Making this function to make the List of Trackable planes public for ObjectSpawner
    public List<ARRaycastHit> get_Array()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
        return hits;
    }
}