using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(.01f, 0, .01f);
    }
}
