using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 
 * This code calculates the distance travelled by utilising the Unity's distance function. 
 * The script also gives the player an EXP value for a set amount of distance travelled.
 * 
 */

public class distanceTravelled : MonoBehaviour
{
    float distance = 0;

    public int score;

    public int EXP = 0;

    //creates an instance to store the last player position.
    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        score = 10;

        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //distance is added to the distance variable 
        distance += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        
        //this piece of code gives the user 10 EXP points for every multiple of 10 the player passes.
        if ((int)distance % 10 == 0)
        {
            EXP += score;
            OnGUI();
        }
    }
    
    public void OnGUI()
    {
        
        GUI.Label(new Rect(0, 0, 100, 100), EXP.ToString());
    }
    
}
