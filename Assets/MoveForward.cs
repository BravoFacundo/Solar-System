using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * 1f;
    }
}
