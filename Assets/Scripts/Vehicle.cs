using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

    [SerializeField]
    public float speed = 20;
    public float turnSpeed = 45;
    public float horizontalInput;
    public float forwardInput;

    void FixedUpdate() {

        Move();

    }

    public virtual void Move() {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

    }
}