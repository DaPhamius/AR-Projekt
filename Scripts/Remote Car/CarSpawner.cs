using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject car;
    public GameObject placementIndicator;
    public GameObject carControls;
    public GameObject placeCarButton;
    public GameObject building;

    private void Start()
    {
        car.SetActive(false);
        carControls.SetActive(false);
        placeCarButton.SetActive(true);
        placementIndicator.SetActive(true);
        building.SetActive(false);
    }

    public void OnPlaceCarButton()
    {
        car.SetActive(true);
        car.transform.position = placementIndicator.transform.position;
        building.SetActive(true);
        building.transform.position = placementIndicator.transform.position;
        carControls.SetActive(true);
        placeCarButton.SetActive(false);
        placementIndicator.SetActive(false);
    }
}
