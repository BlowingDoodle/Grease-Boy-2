using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    private float movHor;
    private float movVert;
    private Vector3 playerInput;
    private Vector3 movePlayer;
    private Vector3 camForward;
    private Vector3 camRight;

    public CharacterController player;
    public Camera mainCamera;

    public float gravity = 9.8f;
    public float fallSpeed; 
    public float playerSpeed;
    public float jumpForce;


    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movHor = Input.GetAxis("Horizontal");
        movVert = Input.GetAxis("Vertical");

        playerInput = new Vector3(movHor, 0 , movVert);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * playerSpeed;

        player.transform.LookAt(player.transform.position + movePlayer);

        setGravity();

        playerSkills();

        player.Move(movePlayer * Time.deltaTime);

        
    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    void playerSkills()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallSpeed = jumpForce;
            movePlayer.y = fallSpeed;
        }
    }

    void setGravity()
    {
        if (player.isGrounded)
        {
            fallSpeed = -gravity * Time.deltaTime;
            movePlayer.y = fallSpeed;
        }
        else
        {
            fallSpeed -= gravity * Time.deltaTime;
            movePlayer.y = fallSpeed;
        }
    }

 

    
}
