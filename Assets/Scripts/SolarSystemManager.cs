using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int planetCount;
    public bool trails;

    [Header("System Conditions")]
    public bool blackHole;
    public bool planetColitions;
    public bool life;


    [Header("References")]
    [SerializeField] private List<GameObject> planets; 

    [Header("Prefabs")]
    [SerializeField] private GameObject planet;
    [SerializeField] private GameObject trail;


    void Start()
    {
        GameObject newSun = Instantiate(planet, transform);
        newSun.transform.parent = null; 
        newSun.transform.position = Vector3.zero;
        float newSunScale = Random.Range(0.1f, 6f);
        newSun.transform.localScale *= newSunScale; // = new Vector3(scale, scale, scale);
        newSun.name = GenerateName();
        //Falta color, black hole?

        for (int i = 0; i < planetCount; i++)
        {
            GameObject newPlanet = Instantiate(planet, transform);
            newPlanet.transform.parent = null;
            newPlanet.transform.position = new Vector3(0,0, newSunScale/2 + Random.Range(1f, 10f));
            float newPlanetScale = Random.Range(0.1f, 1f);
            newPlanet.transform.localScale *= newPlanetScale;

            newPlanet.name = GenerateName();
            planets.Add(newPlanet);
        }
        //Falta color, rotacion inicial, cantidad de lunas, etc.
        //Instanciar objeto trail y hacerlo hijo del planeta.
    }

    void Update()
    {
        
    }

    string GenerateName()
    {
        string randomName = "";
        string characters = "abcdefghijkmnopqrstuvwxyz0123456789";
        for (int i = 0; i < Random.Range(3, 10); i++)
        {
            randomName += characters[Random.Range(0, characters.Length)];
        }

        return randomName;
    }
}
