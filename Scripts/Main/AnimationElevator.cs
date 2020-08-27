using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimationElevator : MonoBehaviour
{

    public Animator anim;
    public bool first_stop;
    public bool elevatorButtonPressed;
    public Camera cam;
    public bool encounter_meteors;
    public bool allbloodcellscured;
    public bool postCrossFade;

    // Start is called before the first frame update
    void Start()
    {
        first_stop = false;
        elevatorButtonPressed = false;
        anim = GetComponent<Animator>();
        cam = Camera.main;
        encounter_meteors = false;
        allbloodcellscured = false;
        ImageFade image = GameObject.FindGameObjectWithTag("UI").GetComponent<ImageFade>();
        postCrossFade = false;



        //Coroutine Approach
        /*
        StartCoroutine(OnWaitAnimation("CINEMA_4D_Main"));
        anim.SetBool("Start", true);
        */
    }




    void Update()
    {



        if (first_stop == false && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.152f)
        {
            anim.speed = 0.0f;
            first_stop = true;
        }

        // For live
        /*if (!elevatorButtonPressed && first_stop == true && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Button"))
                {
                    elevatorButtonPressed = true;
                    anim.speed = 1.0f;
                }
            }
        }*/

        
        //For computertesting
        //Button first stop
        if (!elevatorButtonPressed && first_stop == true && Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Button"))
                {
                    elevatorButtonPressed = true;
                    anim.speed = 1.0f;
                }

            }
        }
        

        if (encounter_meteors == false && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.273f)
        {
            encounter_meteors = true;
        }

        if (encounter_meteors == true && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.526f)
        {
            encounter_meteors = false;
        }

        BloodCells bloodcellsHealed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BloodCells>();

        //add condition in if statement
        if (bloodcellsHealed.allSickBloodcellsHealed == false && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.818f)
        {
            anim.Play("CINEMA_4D_Main", 0, 0.719f);
            //animationElevator["CINEMA_4D_Main"].time = 2.7f;
            //animationElevator["CINEMA_4D_Main"].time = 48.7f;
            // Loop from frame 100-120            
        }


        ImageFade image = GameObject.FindGameObjectWithTag("UI").GetComponent<ImageFade>();

        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.992f)
        {
            StartCoroutine(image.FadeImage(true));
            postCrossFade = true;
        }

    }

}

