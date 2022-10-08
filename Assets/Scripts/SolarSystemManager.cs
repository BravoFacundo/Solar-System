using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private int planetCount;
    public bool blackHole;
    public bool life;

    [Header("References")]
    [SerializeField] private List<GameObject> planets; 

    [Header("Prefabs")]
    [SerializeField] private GameObject planet;
    [SerializeField] private GameObject trail;


    void Start()
    {
        //Generar el sol, tamaño, color, ubicar en 0, es black hole?

        //Generate planets
        //For Loop, planetCount
        //Intanciar prefab de planeta, guardar la referencia dentro del loop
        //Agregar planeta a la lista de planetas
        //Instanciar objeto trail y hacerlo hijo del planeta.
        //Modificar valores del planeta, distancia al sol, tamaño, rotacion inicial, cantidad de lunas,etc.
    }

    void Update()
    {
        
    }
}
