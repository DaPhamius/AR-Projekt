using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{

    public bool hasCollided;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        hasCollided = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter (Collider hit)
    {
        if (hit.tag == "Mask")
        {
            gameObject.SetActive(true);
            hasCollided = true;
        }
    }
}
