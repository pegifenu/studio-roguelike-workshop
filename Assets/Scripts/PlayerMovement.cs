using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
    }
}
