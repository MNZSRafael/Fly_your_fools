using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCarrossel : MonoBehaviour
{
    public VariavelCompartilhada velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;
    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }
    void Update()

    {
        float deslocamento = Mathf.Repeat(this.velocidade.valor * Time.time, tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;

    }

}
