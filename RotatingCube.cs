using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    [SerializeField] private Vector3 rotationConst; 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationConst * Time.deltaTime);
    }
}
