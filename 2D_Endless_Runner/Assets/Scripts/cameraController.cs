using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public playerMovement thePlayer;

    public Transform bg1;

    public Transform bg2;

    private float size;


    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
        thePlayer = FindObjectOfType<playerMovement>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    
    void Update()
    {
        //camera control
        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x,distanceToMove + transform.position.y,transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

        //endless Background
        if (transform.position.y >= bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwitchBg();
        }
    }

    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
}
