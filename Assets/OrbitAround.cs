using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    private GameObject orbitAround;
    [SerializeField] float scale;
    [SerializeField] float distance;
    [SerializeField] float velocity;

    void Start()
    {
        if(gameObject.CompareTag("Star") || gameObject.CompareTag("Planet")) 
            orbitAround = GameObject.Find("Sun");
        if(gameObject.CompareTag("Moon") ) orbitAround = GameObject.Find("Earth");
        //transform.position = new Vector3(transform.position.x, transform.position.y, distance);
        //transform.localScale = new Vector3(scale,scale,scale);
    }
        
    void Update()
    {
        transform.RotateAround(orbitAround.transform.position, Vector3.up, velocity * Time.deltaTime);
    }
}
