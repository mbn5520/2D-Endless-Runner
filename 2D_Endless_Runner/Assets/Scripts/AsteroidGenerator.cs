using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    //public GameObject theAsteroid;
    public Transform GenerationPoint;
    public float DistanceBetween;

    private int randomNumber;

    public float timer = 2f;

    List<GameObject> prefabList = new List<GameObject>();
    public GameObject asteroid_1;
    public GameObject asteroid_2;
    public GameObject asteroid_3;
    public GameObject asteroid_4;
    public GameObject asteroid_5;
    public GameObject asteroid_6;
    public GameObject asteroid_7;
    public GameObject asteroid_8;
    public GameObject asteroid_9;
    public GameObject asteroid_10;








    // Start is called before the first frame update
    void Start()
    {
        prefabList.Add(asteroid_1);
        prefabList.Add(asteroid_2);
        prefabList.Add(asteroid_3);
        prefabList.Add(asteroid_4);
        prefabList.Add(asteroid_5);
        prefabList.Add(asteroid_6);
        prefabList.Add(asteroid_7);
        prefabList.Add(asteroid_8);
        prefabList.Add(asteroid_9);
        prefabList.Add(asteroid_10);
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(-8,8);

        if(transform.position.y < GenerationPoint.position.y)
        {
           transform.position = new Vector3(transform.position.x - randomNumber, transform.position.y + DistanceBetween, transform.position.z);

            //transform.position = new Vector3(transform.position.x, transform.position.y + DistanceBetween, transform.position.z);

            timer -=Time.deltaTime;

            if(timer <= 0)
            {
                int prefabIndex = UnityEngine.Random.Range(0,9);
                Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);
                timer = .2f;
            }
        }
    }
}
