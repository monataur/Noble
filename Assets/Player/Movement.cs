using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
#pragma warning disable 649
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f;
    public Vector2 horizontalInput;

    [SerializeField] float jumpHeight = 3.5f;
    bool jump;

    [SerializeField] float gravity = -30f;
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask groundMask;
    public bool isGrounded;

    //soundsources
    public AudioSource jumpSource;

    public bool moveEnabled = false;
    public bool cursorEnabled = false;

    private void Update()
    {
        Debug.Log("update");
        switch (cursorEnabled)
        {
            case true:
                Cursor.visible = true;
                break;

            case false:
                Cursor.visible = false;
                break;
        }
        if(moveEnabled == true)
        {
            isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
            if (isGrounded == true)
            {
                verticalVelocity.y = 0;
            }

            Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
            controller.Move(horizontalVelocity * Time.deltaTime);

            // Jump: v = sqrt(-2 * jumpHeight * gravity)
            if (jump)
            {
                if (isGrounded)
                {
                    verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
                }
                jumpSource.Play();
                jump = false;
            }

            verticalVelocity.y += gravity * Time.deltaTime;
            controller.Move(verticalVelocity * Time.deltaTime);
        }
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
    }

    public void OnJumpPressed()
    {
        jump = true;
    }
}
