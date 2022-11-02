using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainCubeScript : MonoBehaviour
{
    //public TMP_InputField InputSpeed;
    private Vector3 direction;

    private float AllDistanceTraveled = 0;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.insideUnitCircle.normalized;
    }

    void Update()
    {
        float DistanceTraveled = CubeState.getSpeed() * Time.deltaTime;
        transform.Translate(direction * DistanceTraveled);

        AllDistanceTraveled = AllDistanceTraveled + DistanceTraveled;
        if (AllDistanceTraveled >= CubeState.getDistance())
        {
            Destroy(this.gameObject);
        }
    }
}
