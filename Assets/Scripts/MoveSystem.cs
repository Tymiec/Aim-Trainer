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
        playerInputActions.Player.Jump.performed += Jump;
        // playerInputActions.Player.Movement.performed += Movement_performed;
    }

    private void FixedUpdate() 
    { ///move the player on update
        
        // Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        // float speed = 5f;
        // capsuleRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);    

        // Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        // float speed = 5f;
        // capsuleRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
        // Debug.Log("Update!");
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
        // jump the player
        // Debug.Log("Jumping! " + context.phase);
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Jumping!");
            capsuleRigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
