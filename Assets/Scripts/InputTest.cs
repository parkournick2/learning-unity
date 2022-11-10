using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [Header("Variables")]
    public int moves = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) moves++;
    }
}
