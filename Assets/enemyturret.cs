using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyturret : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject BulletPrefab;
    float timer;
    public float bps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > bps)
        {
            Instantiate(BulletPrefab, Firepoint.position, Firepoint.rotation);
            timer = 0;
        }
        
    }
}
