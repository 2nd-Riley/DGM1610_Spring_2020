using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{

    // Variables
    public float speed;
    public float turnSpeed;
    public float verticleInput;
    public float horizontalInput;
    float horizontalCap;
    float verticalCap;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        verticalCap = 5;
        horizontalCap = 11.5f;
    }

    // Update is called once per frame
    void Update()
    {
        verticleInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //Rotates with left and right
        //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        if (transform.position.z > -verticalCap && verticleInput < 0)
        {
            transform.Translate(Vector3.forward * verticleInput * speed * Time.deltaTime);
        }
        if (transform.position.z < verticalCap && verticleInput > 0)
        {
            transform.Translate(Vector3.forward * verticleInput * speed * Time.deltaTime);
        }
        if (transform.position.x > -horizontalCap && horizontalInput < 0)
        {
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        }
        if (transform.position.x < horizontalCap && horizontalInput > 0)
        {
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        }
    }

    /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Hit the floor");
        } else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit an object");
        } else
        {
            Debug.Log("...");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You have entered the trigger");
    }  */
}
