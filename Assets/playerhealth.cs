using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class playerhealth : MonoBehaviour
{
    public int health;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
