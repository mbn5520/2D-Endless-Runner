using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour
{

    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    public float shipSpeed = 5;

    private Rigidbody2D enemyRB;

    void Start()
    {
        startPos = transform.position;
        enemyRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        enemyRB.velocity = new Vector2(shipSpeed, enemyRB.velocity.x);

        Vector3 v = transform.position;//startPos;
        v.x += (delta * Mathf.Sin(Time.time * speed))/2;
        transform.position = v;
    }
}