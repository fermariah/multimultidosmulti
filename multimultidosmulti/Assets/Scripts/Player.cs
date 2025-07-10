using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject balaProjetil; // vai ser a bala - mariah;
    public Transform arminha; //posição de onde vai sair o tiro - mariah
    private bool tiro; //input do tiro - mariah
    public float forcaTiro;
    private bool flipX = false;

    public float velocidade;
    public Rigidbody2D playerRB;
    private float PlayerMOVE; //movimento do player - mariah
    public float puloForca; //força do pulo - mariah
    public bool pulo, isgrounded;

    void Start()
    {

    }


    void Update()
    {
        PlayerMOVE = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(PlayerMOVE * velocidade, playerRB.velocity.y);
        pulo = Input.GetButtonDown("Jump");
        tiro = Input.GetButtonDown("Fire1");

        Atirar();

        if (pulo == true && isgrounded == true)
        {
            playerRB.AddForce(new Vector2(0, puloForca));
            isgrounded = false;
        }

        if (PlayerMOVE > 0) //para o player virar de lado quando clicar nos arrows left e right - mariah
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (PlayerMOVE < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }

    private void OnCollisionEnter2D(Collision2D cOl) //método pro pulo
    {
        if (cOl.gameObject.CompareTag("chao"))
        {
            isgrounded = true;
        }
        
    }

    private void Atirar()
    {

    }
}