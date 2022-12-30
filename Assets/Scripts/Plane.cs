using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle {

    public override void Move() {

        transform.Translate(Vector3.forward * speed);
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * forwardInput);

    }

}