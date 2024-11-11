using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    
    private PlayerControls playercontrols;
    private Rigidbody2D rb;
    public float movespeed;
    void Start()
    {
        playercontrols = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnMoving(InputValue inputValue)
    {
        inputValue.Get<Vector2>();

        rb.velocity = inputValue.Get<Vector2>()*movespeed;
    }
}
