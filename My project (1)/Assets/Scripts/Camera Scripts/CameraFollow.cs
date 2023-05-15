using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float lerpFactor = 0.5f;
    public float yOffset;
    public float zOffset;

    void FixedUpdate()
    {  // Creating new Vector3 variable to the player's position and then i set the camera position to the variable + y-offset and z-offset
        Vector3 camPos = Vector3.Lerp(transform.position,player.position,lerpFactor);
        transform.position = new Vector3(camPos.x, camPos.y + yOffset, -zOffset);
    }
}
