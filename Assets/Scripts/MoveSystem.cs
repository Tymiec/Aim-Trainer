using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveSystem : MonoBehaviour
{
    private Rigidbody capsuleRigidbody;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        capsuleRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump; // subscribe to jump event
    }

    void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 5f;
        // add velocity to player
        capsuleRigidbody.velocity = new Vector3(inputVector.x, 0, inputVector.y) * speed;

    }

    
    public void Movement_performed(InputAction.CallbackContext context)
    {
        Debug.Log("context: " + context);

        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 5f;
        capsuleRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Jumping!");
            capsuleRigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
