using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
public class boundaries : MonoBehaviour
{
=======
public class boundaries : MonoBehaviour {
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -8.5f, 8.5f);
        transform.position = pos;
    }
}
