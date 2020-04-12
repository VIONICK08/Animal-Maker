using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControll : MonoBehaviour
{
    public float speedRotation;
    public GameObject target;
    public float speedRotationPlanet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0f, speedRotation * Time.deltaTime, 0f);
        target.transform.rotation *= Quaternion.Euler(0f, speedRotationPlanet * Time.deltaTime, 0f);
    }
}
