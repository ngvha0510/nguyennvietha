using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float timeSpawn = 2;
    public GameObject prefabsBird;
    public Transform parrentBird;
    public Transform parrentPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn < 0)
        {
            Vector3 positionSpawn = parrentPosition.position;
            positionSpawn.x = Random.Range(-11.34f, 11.34f);
            positionSpawn.y = Random.Range(-5f, 5f);
            Instantiate(prefabsBird, positionSpawn, Quaternion.identity, parrentBird);
            timeSpawn = Random.Range(0f, 1f);

        }
    }
}
