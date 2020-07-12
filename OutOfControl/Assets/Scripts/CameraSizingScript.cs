using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizingScript : MonoBehaviour
{
    public Camera cam;
    public float varibal;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            cam.orthographicSize = varibal;
        }
    }
}
