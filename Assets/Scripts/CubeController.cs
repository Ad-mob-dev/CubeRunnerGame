using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Transform directionalObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
           transform.position = Vector3.MoveTowards(transform.position, directionalObj.transform.position , 4f);
        }
    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Obstacles")) 
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}
