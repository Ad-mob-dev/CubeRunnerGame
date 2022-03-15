using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    //Refrences
    Rigidbody rb;
    float speed = 300.0f;
    int health = 100;

    public UnityEvent OnMove;
    public UnityEvent OnPlayerHurt;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        OnMove.Invoke();
        OnPlayerHurt.Invoke();

    }

    public void OnHurt()
    {
        
        health = health - 1;
        if(health == 0)
        {

            Debug.Log("Health is :" +  health);
        }
    }
    public void MovePlayer()
    {


        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.VelocityChange);


        }
        


        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            rb.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.VelocityChange);

        }


        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4)
            {
                rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 4)
            {

                rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.VelocityChange);
            }

        }
    }

}
