using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private distanceTravelled dt;

    private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        dt = FindObjectOfType<distanceTravelled>();

        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string display = dt.EXP.ToString();
        tmp.SetText(display);
    }
}
