 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    public GameObject enemyBullet;

    public float fireDelay = 0.2f;

    float enemyFireCooldown = 0;

    public Renderer enemyRenderer;

    private void Start()
    {
        enemyRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        enemyFireCooldown -= Time.deltaTime;

        //if(enemyRenderer.isVisible)
        //{
            if (enemyFireCooldown <= 0)
            {
                enemyFireCooldown = fireDelay;

                Vector3 offset = transform.rotation * bulletOffset;

                GameObject bulletGo = (GameObject)Instantiate(enemyBullet, ((transform.position) + offset), transform.rotation);

                bulletGo.layer = gameObject.layer;
        }

        //}
    }
}


