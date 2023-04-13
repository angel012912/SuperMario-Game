using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX = 10;    // Horizontal (para movimiento horizontal) 
    public float velocidadY = 10;    // Vertical (para el salto) 
    // El componente Rigidbody del personaje (para física) 
    private Rigidbody2D rb;
    // Start is called before the first frame update 
    //Animator 
    private Animator animator;
    //Sprite Renderer
    private SpriteRenderer sprRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        //Direccion correcta
        sprRenderer.flipX = rb.velocity.x > 0;
    }
}