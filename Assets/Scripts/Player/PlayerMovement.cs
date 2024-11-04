using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    [SerializeField, Range(0f, 1f)]
    private float m_Deceleration = 0.9f;

    [SerializeField]
    private float m_MoveSpeed = 5f;

    private Vector2 _direction = Vector2.zero;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        _direction = direction;
    }

    private void FixedUpdate()
    {
        // Appliquer la direction de mouvement en multipliant par la vitesse
        Vector2 targetVelocity = _direction * m_MoveSpeed;

        // Appliquer la vitesse cible et ajouter une décélération progressive
        _rigidBody.velocity = Vector2.Lerp(_rigidBody.velocity, targetVelocity, m_Deceleration);
    }
}
