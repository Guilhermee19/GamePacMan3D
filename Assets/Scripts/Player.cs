using UnityEngine;

public class Player : MonoBehaviour {

    CharacterController controller;

    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;

    float forwardSpeed = 6f;
    float strafeSpeed = 6f;


    void Start() {

        controller = GetComponent<CharacterController>();

    }

    void Update() {


        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        // force = input * speed * direction
        forward = -forwardInput * forwardSpeed * transform.forward;
        strafe = -strafeInput * strafeSpeed * transform.right;

        Vector3 finalVelocity = forward + strafe + vertical;

        controller.Move(finalVelocity * Time.deltaTime);


    }

}
