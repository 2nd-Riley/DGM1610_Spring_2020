using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Variables
    public float speed;
    public float turnSpeed;
    public float verticleInput;
    public float horizontalInput;
    //float horizontalCap;
    //float verticalCap;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        turnSpeed = 100;
        //verticalCap = 5;
        //horizontalCap = 11.5f;
    }

    // Update is called once per frame
    void Update()
    {
        verticleInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //Rotates with left and right
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
            transform.Translate(Vector3.forward * verticleInput * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
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
    } */

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
