using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceTravelled : MonoBehaviour
{
    float distance = 0;

    public int EXP = 0;

    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        //Debug.Log((int)distance);

        if ((int)distance % 10 == 0)
        {
            EXP += 10;
            OnGUI();
        }
    }

    public void OnGUI()
    {
        
        GUI.Label(new Rect(0, 0, 100, 100), EXP.ToString());
    }
}
