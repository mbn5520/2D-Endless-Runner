using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public playerMovement thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    
    void Update()
    {
        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x,distanceToMove + transform.position.y,transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
    }
}
