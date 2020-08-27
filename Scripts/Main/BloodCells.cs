using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BloodCells : MonoBehaviour
{
    public ProgressBar score;
    public GameObject image;
    public Camera cam;
    public Material newMaterialRef;
    public GameObject sickBloodCell1;
    public GameObject sickBloodCell2;
    public GameObject sickBloodCell3;
    public bool sickBloodcell1healed;
    public bool sickBloodcell2healed;
    public bool sickBloodcell3healed;
    public bool allSickBloodcellsHealed;
    public GameObject imageWhite;






    private void Awake()
    {
        newMaterialRef = new Material(newMaterialRef);

    }
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        sickBloodcell1healed = false;
        sickBloodcell2healed = false;
        sickBloodcell3healed = false;
        allSickBloodcellsHealed = false;

    }

    // Update is called once per frame
    void Update()
    {
        sickBloodCell1 = GameObject.Find("Arterie_Bad_Cell_001");
        sickBloodCell2 = GameObject.Find("Arterie_Bad_Cell_002");
        sickBloodCell3 = GameObject.Find("Arterie_Bad_Cell_003");

        // During blood cells
        //Live
        /*if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("badBloodcells1"))
                {
                    sickBloodCell1.GetComponent<Renderer>().material = new Material(newMaterialRef);
                    sickBloodcell1healed = true;
                    score.UpdateScore(1);



                }
                if (hit.collider.CompareTag("badBloodcells2"))
                {
                    sickBloodCell2.GetComponent<Renderer>().material = new Material(newMaterialRef);
                    sickBloodcell2healed = true;
                    score.UpdateScore(1);


                }

                if (hit.collider.CompareTag("badBloodcells3"))
                {
                    sickBloodCell3.GetComponent<Renderer>().material = new Material(newMaterialRef);
                    sickBloodcell3healed = true;
                    score.UpdateScore(1);


                }
            }
        }

        if (sickBloodcell1healed == true && sickBloodcell2healed == true && sickBloodcell3healed == true)
        {
            allSickBloodcellsHealed = true;
            image.SetActive(true);
        }
        else
        {
            allSickBloodcellsHealed = false;
        }
    }
    */

        // ComputerTesting
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("badBloodcells1") && sickBloodcell1healed == false)
                {
                    sickBloodCell1.GetComponent<Renderer>().material = new Material (newMaterialRef);
                    sickBloodcell1healed = true;
                    score.UpdateScore(1);



                }
                if (hit.collider.CompareTag("badBloodcells2") & sickBloodcell2healed == false)
                {
                    sickBloodCell2.GetComponent<Renderer>().material = new Material(newMaterialRef);
                    sickBloodcell2healed = true;
                    score.UpdateScore(1);


                }

                if (hit.collider.CompareTag("badBloodcells3") & sickBloodcell3healed == false)
                {
                    sickBloodCell3.GetComponent<Renderer>().material = new Material(newMaterialRef);
                    sickBloodcell3healed = true;
                    score.UpdateScore(1);


                }
            }
        }

        if (sickBloodcell1healed == true && sickBloodcell2healed == true && sickBloodcell3healed == true)
        {
            allSickBloodcellsHealed = true;
            imageWhite.SetActive(true);
        }
        else
        {
            allSickBloodcellsHealed = false;
        }

    }
    
    }
