using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float vertical;
    private float velocidade = 8f;
    private bool escadinha;
    private bool escalar;
    public Rigidbody2D playerRb; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (escadinha && Mathf.Abs(vertical) > 0f) //para fazer o player escalar - mariah
        {
            escalar = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D cOl)
    {
        if (cOl.CompareTag("escadinha"))
        {
            escadinha = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("escadinha"))
        {
            escadinha = false;
            escalar = false;
        }
    }

    private void FixedUpdate()
    {
        if (escalar == true)
        {
            playerRb.gravityScale = 0f;
            playerRb.velocity = new Vector2(playerRb.velocity.x, vertical * velocidade);
        }

        else
        {
            playerRb.gravityScale = 2f;
        }
    }
}
