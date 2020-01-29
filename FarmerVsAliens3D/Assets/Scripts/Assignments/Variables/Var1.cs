using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{

    // Variables
    public float amount;
    public float money;
    public float cost;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
    }

    private void OnCollisionEnter(Collision collision)
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
        
    }
}
