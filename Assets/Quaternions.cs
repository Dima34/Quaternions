using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternions : MonoBehaviour
{
    [SerializeField] GameObject dist;
    [SerializeField] float rotSpeed = 90f; // Rotation speed in degrees per second
    
    Quaternion q = Quaternion.AngleAxis(90f, Vector3.up);
    Quaternion q2 = Quaternion.AngleAxis(45f, Vector3.left);

    
    
    // Start is called before the first frame update
    void Start()
    {
        // transform.rotation = q * q2;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, transform.up);
        transform.rotation *= q;

        // Visualise the vector between

        Vector3 diff = dist.transform.position - transform.position;
        Debug.DrawLine(transform.position.normalized, diff, Color.red);
    }
}
