using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public void ColorChange() // Anim Event
    {
        var material = GetComponent<Renderer>().material;
        material.color = Color.yellow;
    }
}
