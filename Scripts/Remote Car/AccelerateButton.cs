using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateButton : MonoBehaviour
{


    public void OnDown()
    {
        Car.instance.doAccelerate = true;
    }

    public void OnUp()
    {
        Car.instance.doAccelerate = false;
    }

    public void ReverseDown()
    {
        Car.instance.doReverse = true;
    }

    public void ReverseUp()
    {
        Car.instance.doReverse = false;
    }
}
