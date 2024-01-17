using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10f;
    private ControlaCena diretor;
    private bool deveImpulsionar;
    private Animator animacao;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<ControlaCena>();
        animacao = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            deveImpulsionar = true;
        }
        this.animacao.SetFloat("VelocidadeY", this.fisica.velocity.y);

    }

    private void FixedUpdate()
    {
        if (deveImpulsionar)

        { 
            this.Impulsionar(); 
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca,ForceMode2D.Impulse);
        deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
}
