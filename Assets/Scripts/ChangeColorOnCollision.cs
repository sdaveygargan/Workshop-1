using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    public Color changeColorTo = Color.white; // By default change the color to white

    void OnCollisionEnter()
    {
        // Find the component 'Renderer', and change the color of the Material accordingly:
        gameObject.GetComponent<Renderer>().material.color = changeColorTo;
    }
}
