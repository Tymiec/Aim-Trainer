using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MoveSystem : MonoBehaviour
{
    public void MoveForward(InputAction.CallbackContext context)
    {
        // move the player forward
        Debug.Log("Moving forward! " + context.phase);
        if (context.phase == InputActionPhase.Started)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20);
        }
    }

    public void MoveBackward(InputAction.CallbackContext context)
    {
        // move the player backward
        Debug.Log("Moving backward! " + context.phase);
        if (context.phase == InputActionPhase.Started)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 20);
        }
    }

    public void MoveLeft(InputAction.CallbackContext context)
    {
        // move the player left
        Debug.Log("Moving left! " + context.phase);
        if (context.phase == InputActionPhase.Started)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 20);
        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        // move the player right
        Debug.Log("Moving right! " + context.phase);
        if (context.phase == InputActionPhase.Started)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20);
        }
    }
}
