using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    private Rigidbody enemyRb;
    public bool isCylinder;
    //public Transform target;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*target = player.transform;
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);*/
    }

    void FixedUpdate()
    {
        if (isCylinder) {
            if (transform.rotation.z > 60 || transform.rotation.z < -60)
            {

            }
            if (transform.rotation.x > 60 || transform.rotation.x < -60)
            {

            }
        }
        // Change Velocity
            //enemyRb.velocity = player * moveSpeed;
        // Add Force
            enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
        // Move Position
            //enemyRb.MovePosition((player.transform.position - transform.position).normalized * moveSpeed);
    }
}