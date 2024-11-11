using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        

    }
}
