using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{

    public int maxScore = 7;
    public int currentScore;
    public ScoreBar scoreBar;
    public ObjectSpawner hasItSpawned;
    public bool first_pointGiven;
    public bool second_pointGiven;
    //public bool found_elevator;
    public GameObject ScoreBar;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        scoreBar.SetScore(currentScore);
        first_pointGiven = false;
        second_pointGiven = false;
        

    }

    // Update is called once per frame
    void Update()
    {

        AnimationElevator elevatorTarget = GameObject.FindGameObjectWithTag("Elevator").GetComponent<AnimationElevator>();


        /* if (hasItSpawned.HasSpawned == true && !first_pointGiven)
        {
            if (first_pointGiven == false)
            UpdateScore(1);
            first_pointGiven = true;
        }
        */

        if (elevatorTarget.elevatorButtonPressed == true && !second_pointGiven)
        {
            if (second_pointGiven == false)
            {
                UpdateScore(1);
                second_pointGiven = true;
                ScoreBar.SetActive(true);
            }
        }
    }

    public void UpdateScore(int score)
    {
        currentScore += score;

        scoreBar.SetScore(currentScore);
    }
}
