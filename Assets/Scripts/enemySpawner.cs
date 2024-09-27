using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpawner : MonoBehaviour
{
    public GameObject slime;
    public float minimumTime;
    public float maximumTime;
    public float timeSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime;

        if (timeSpawn <= 0)
        {
            Instantiate(slime, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    public void SetTimeUntilSpawn()
    {
        timeSpawn = Random.Range(minimumTime, maximumTime);
    }
}
