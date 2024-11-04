using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement m_Movement;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }

        m_Movement.Move(direction);
    }
}

