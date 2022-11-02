using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeTimerScript : MonoBehaviour
{
    public GameObject Cube;
    private float t = 0;

    void Update()
    {
        t = t + Time.deltaTime;
        if (t > CubeState.getSpawnRate())
        {
            GameObject clone = Instantiate(Cube, transform.position, Quaternion.identity);
            t = 0;
        }
    }
}
