using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpScript : MonoBehaviour
{
    [Range(0, 1)]
    [SerializeField] float TCoefficient = 0f;
    [SerializeField] Transform fromEx;
    [SerializeField] Transform toEx;

    Quaternion fromRotation;

    private void Start() {
        fromRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // if(TCoefficient <= 1.0f){
        //     TCoefficient += Time.deltaTime;
        // }
        transform.rotation = Quaternion.Slerp(fromEx.rotation, toEx.rotation, TCoefficient);
    }
}
