using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2.15f)
        {
            Instantiate(enemy, transform.position + new Vector3(Random.Range(-5f, 5f), 0, 0), Quaternion.identity);
            timer = 1;
        }
        
    }
}
