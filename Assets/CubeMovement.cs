using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // public float speedX = 0;
    // public float speedZ = 0;
    public float speed = 6;
    public Material[] materials;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        rb.velocity = new Vector3(4, 0, 4) * speed;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (speed == 4)
            {
                speed = -4;
            }
            else
            {
                speed = 4;

            }
            Debug.Log(GetComponent<Renderer>().material.name);
            if (GetComponent<Renderer>().material.name == "Red (Instance)")
            {
                GetComponent<Renderer>().material = materials[1];
                Debug.Log(materials[0].name);

            }
            else
            {
                GetComponent<Renderer>().material = materials[0];
                Debug.Log(materials[0].name);

            }

            // Vector3 reflection = Vector3.Reflect(rb.velocity, other.contacts[0].normal);
            // rb.AddForce(reflection, ForceMode.VelocityChange);
            // Debug.Log("Wall Hit");
            // if (GetComponent<Renderer>().material.name == "Red")
            // {
            //     GetComponent<Renderer>().material = materials[1];
            //     Debug.Log(materials[0].name);

            // }
            // else
            // {
            //     GetComponent<Renderer>().material = materials[0];
            //     Debug.Log(materials[0].name);

            // }
        }
    }
}
