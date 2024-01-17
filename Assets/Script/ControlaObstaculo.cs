using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    public VariavelCompartilhada velocidade;
    public float maximo = 2f;
    public float minimo = -1f;
    private Vector3 posicaoDoAviao;
    private ControlaPontos pontos;
    private bool ponto;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(minimo, maximo));
       

    }

    private void Start()
    {
        this.posicaoDoAviao = GameObject.FindObjectOfType<ControlaAviao>().transform.position;
        this.pontos = GameObject.FindAnyObjectByType<ControlaPontos>();
    }



    private void Update()
    {
        this.transform.Translate(Vector3.left * velocidade.valor * Time.deltaTime);

        if (!this.ponto && this.transform.position.x < this.posicaoDoAviao.x)
        {
            
            this.ponto = true;
            this.pontos.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    private void Destruir ()
    {
        GameObject.Destroy(this.gameObject);
    }
}
