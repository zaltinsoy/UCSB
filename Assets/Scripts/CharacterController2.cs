using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public float rotateDegreesPerSecond = 2880.0f; //180di
    public Animator playerAnim;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        // playerAnim.SetTrigger("Jump_trig");
    }

    void Update()
    {
    //   playerAnim.SetTrigger("Jump_trig");

        //Rotate and move the character based on the input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        if (movementDirection != Vector3.zero)
        {

            if (Vector3.Angle(transform.forward, movementDirection) > 179)
            {

                movementDirection = transform.TransformDirection(new Vector3(.01f, 0, -1));
            }

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(movementDirection), rotateDegreesPerSecond * Time.deltaTime);
            Vector3 moveDirection = transform.forward;
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        }

    }
}
