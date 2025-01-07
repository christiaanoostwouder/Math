using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    public float maxThrust = 10f;
    public float rotationSpeed = 200f;
    public float fuel = 100f;

    private Rigidbody2D rb;
    public float currentThrust = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //thrust changing
        if (Input.GetKey(KeyCode.W) && fuel > 0)
        {
            currentThrust = Mathf.Min(maxThrust, currentThrust + Time.deltaTime * 5);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentThrust = Mathf.Max(0f, currentThrust - Time.deltaTime * 5);
        }

        //rotation
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        //Fuel Using
        if (fuel > 0 && currentThrust > 0)
        {
            fuel -= Time.deltaTime * currentThrust / 10f;
        }
    }

    private void FixedUpdate()
    {
        //adding the movement
        if (fuel > 0)
        {
            rb.AddForce(transform.up * currentThrust);
        }
    }
}
