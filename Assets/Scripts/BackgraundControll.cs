using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgraundControll : MonoBehaviour
{
    public float speedBackgraund;
    public float positiones;
    public float positionEnd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3(speedBackgraund * Time.deltaTime, 0, 0);

    }

    public void FixedUpdate()
    {
        transform.position -= new Vector3(speedBackgraund * Time.deltaTime, 0, 0);
        if (transform.position.x <= positionEnd)
        {
            transform.position = new Vector2(positiones, transform.position.y);
        }
    }
}
