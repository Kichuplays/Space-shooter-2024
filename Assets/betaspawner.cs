using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betaspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemyprefab;

    [SerializeField]
    private float minimumSpawnTime;

    [SerializeField]
    private float maximumSpawnTime;

    private float _timeuntilSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeuntilSpawn -= Time.deltaTime;

        if (_timeuntilSpawn <=0)
        {
            Instantiate(Enemyprefab, transform.position, Quaternion.identity);
        }
    }
    private void SetTimeUntilSpawn()
    {
        _timeuntilSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
    }

}
