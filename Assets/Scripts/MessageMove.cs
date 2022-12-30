using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageMove : MonoBehaviour
{
    public float Speed = 1.0f;

    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new Vector3(xSpeed, ySpeed, zSpeed);
        transform.Translate(vector3 * Time.deltaTime * Speed);
    }

}
