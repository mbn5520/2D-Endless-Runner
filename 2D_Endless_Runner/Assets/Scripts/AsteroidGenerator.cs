using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public GameObject theAsteroid;
    public Transform GenerationPoint;
    public float DistanceBetween;

    public int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(-8,8);

        if(transform.position.y < GenerationPoint.position.y)
        {
            transform.position = new Vector3(transform.position.x - randomNumber, transform.position.y + DistanceBetween, transform.position.z);

            Instantiate(theAsteroid, transform.position, transform.rotation);
        }
    }
}
