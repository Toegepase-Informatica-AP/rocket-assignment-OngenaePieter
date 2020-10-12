using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{

    float rotationLeftRight = 0;
    public float speed = 0;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, speed, 0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotationLeftRight -= 0.01f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationLeftRight += 0.01f;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rotationLeftRight = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rotationLeftRight = 0;
        }

        transform.Rotate(rotationLeftRight, 0, 0, Space.Self);
    }
}
