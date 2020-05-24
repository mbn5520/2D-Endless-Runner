using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This code changes the position of the camera repective to the position of the player.
 * It achieves this functionality by recording the last player position in a variable and moving the camera the same distance the player has moved
 * 
 */

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

        //Here the script will find the specified player object. This player oobject can be specified in Unity editor.
        thePlayer = FindObjectOfType<playerMovement>();

        //here we can see the script recording the last player position and saving it into the variable 'theplayer'
        lastPlayerPosition = thePlayer.transform.position;
    }

    
    void Update()
    {
        //Here we calculate the player position respective to the last player position. Since we only want the3 camera to vertically, only the value of y axis has been recorded.
        //camera control
        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;


        //We then add the distance we want to move the camera and update the camera value accordingly.
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
