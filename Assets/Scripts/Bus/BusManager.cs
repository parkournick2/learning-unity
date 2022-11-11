using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusManager : MonoBehaviour
{
    public Bus[] buses;
}

[System.Serializable]
public class Bus
{
    public GameObject prefab;
    public Color color;

    public Bus(GameObject prefab, Color color)
    {
        this.prefab = prefab;
        this.color = color;
    }
}