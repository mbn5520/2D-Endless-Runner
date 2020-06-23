using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayPowerup : MonoBehaviour
{

    private TextMeshProUGUI tmp;

    private Powerups powerups;

    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();

        powerups = FindObjectOfType<Powerups>();
    }

    // Update is called once per frame
    void Update()
    {


        // check powerup manager to see which powerup is true, display powerup name if true
        //if (powerups.doubleXP == true)
        //{
        //    Debug.Log("Testing");
        //    tmp.SetText("Double XP");
        //}
        //if (powerups.boost)
        //{
        //    Debug.Log("Testing");
        //    tmp.SetText("Boost");
        //}
        //if (powerups.shield)
        //{
        //    tmp.SetText("Added Health");
        //}
        //if (powerups.gunUpgrade)
        //{
        //    tmp.SetText("Upgraded Gun");
        //}
        
    }
}
