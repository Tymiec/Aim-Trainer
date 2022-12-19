using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpSystem : MonoBehaviour
{
    public void Jump(InputAction.CallbackContext context)
    {
        // jump the player
        Debug.Log("Jumping! " + context.phase);
        if (context.phase == InputActionPhase.Started)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 20);
        }
    }
}
