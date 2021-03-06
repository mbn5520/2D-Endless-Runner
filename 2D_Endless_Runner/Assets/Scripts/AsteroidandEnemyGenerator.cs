﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This script generates random asteroids for the player to shoot on the screen. 
 * The way this script works is, it generates a set of list of game objects which can be populated with prefabs of asteroids
 * These prefabs can then be placed on the screen by calling the instantiate function
 * 
 * **/

public class AsteroidandEnemyGenerator : MonoBehaviour
{
    //public GameObject theAsteroid;
    public Transform GenerationPoint;
    public float DistanceBetween;

    private int randomNumber;

    public float timer = 10f;

    
    //Generating the list for the prefabs
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
    //We can just add enemy game object below, I've only added 2 for experimenting
    //We can add more as soon as we get more sprites.
    public GameObject enemy_1;
    public GameObject enemy_2;
    public GameObject enemy_3;
    public GameObject enemy_4;
    public GameObject enemy_5;
    public GameObject enemy_6;
    public GameObject enemy_7;
    public GameObject enemy_8;
    public GameObject enemy_9;
    public GameObject enemy_10;

    public GameObject powerup_1;
    public GameObject powerup_2;
    public GameObject powerup_3;
    public GameObject powerup_4;

  





    // Start is called before the first frame update
    void Start()
    {
        //Here, The list is being populated with all the available prefabs in the folder.
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
        //Same as above, we can add more enemies and the script below will take care of everything
        prefabList.Add(enemy_1);
        prefabList.Add(enemy_2);

        prefabList.Add(enemy_3);

        prefabList.Add(enemy_4);
        prefabList.Add(enemy_5);
        prefabList.Add(enemy_6);
        prefabList.Add(enemy_7);
        prefabList.Add(enemy_8);
        prefabList.Add(enemy_9);
        prefabList.Add(enemy_10);

        prefabList.Add(powerup_1);
        prefabList.Add(powerup_2);
        prefabList.Add(powerup_3);
        prefabList.Add(powerup_4);
    
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(-8,8);

        //this if function will check if the position of object Generation point is higher than the object Asteroid generator
        // if it is, this script will move the object Asteroid generator by a set amount on the x and y axis.
        //it will then place an aasteroid after a certain amount of time.
        if(transform.position.y < GenerationPoint.position.y)
        {
           transform.position = new Vector3(transform.position.x - randomNumber, transform.position.y + DistanceBetween, transform.position.z);

            //transform.position = new Vector3(transform.position.x, transform.position.y + DistanceBetween, transform.position.z);

            timer -=Time.deltaTime;

            //this if statement checks if the set amount of time has been passed in real time and then places a random asteroid on the screen

            if(timer <= 0)
            {
                int prefabIndex = UnityEngine.Random.Range(0,23);
                Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);

                
                timer = .8f;
            }
        }
    }
}
