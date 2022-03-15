using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Refrences
    public GameObject player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        //Camera Follow Player
        if (player != null)
        {
            transform.position = player.transform.position + offset;
            transform.LookAt(player.transform);
        }

    }
}
