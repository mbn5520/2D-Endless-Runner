using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGenerator : MonoBehaviour
{
    public Transform GenerationPoint;
    public float DistanceBetween;

    private int randomNumber;

    public float timer = 10f;

    //Generating the list for the prefabs
    List<GameObject> powerups = new List<GameObject>();
    public GameObject doubleXP;
    public GameObject shield;
    public GameObject boost;

    // Start is called before the first frame update
    void Start()
    {
        //Here, The list is being populated with all the available prefabs in the folder.
        powerups.Add(doubleXP);
        powerups.Add(shield);
        powerups.Add(boost);
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(-8, 8);

        //this if function will check if the position of object Generation point is higher than the object Powerup generator
        // if it is, this script will move the object Powerup generator by a set amount on the x and y axis.
        //it will then place an aasteroid after a certain amount of time.
        if (transform.position.y < GenerationPoint.position.y)
        {
            transform.position = new Vector3(transform.position.x - randomNumber, transform.position.y + DistanceBetween, transform.position.z);

            //transform.position = new Vector3(transform.position.x, transform.position.y + DistanceBetween, transform.position.z);

            timer -= Time.deltaTime;

            //this if statement checks if the set amount of time has been passed in real time and then places a random Powerup on the screen

            if (timer <= 0)
            {
                int prefabIndex = UnityEngine.Random.Range(0, 3);
                Instantiate(powerups[prefabIndex], transform.position, transform.rotation);
                timer = .2f;
            }
        }
    }
}
