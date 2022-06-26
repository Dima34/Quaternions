using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmonic : MonoBehaviour
{
    [SerializeField] float range = 20f;
    float theta = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = range * Mathf.Sin(theta);
        theta += Time.deltaTime;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = q;
    }
}
