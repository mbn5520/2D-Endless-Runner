using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firedShots : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 shotPosition = transform.position;
        shotPosition.y +=  moveSpeed * Time.deltaTime;

        transform.position = shotPosition;
    }
}
