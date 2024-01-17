using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{

    public float tempoParaGerarFacil;
    public float tempoParaGerarDificil;
    public float cronometro;
    public GameObject obstaculo;
    private ControlaDificuldade dificuldade;

    private void Awake()
    {
        cronometro = tempoParaGerarFacil;
    }

    private void Start()
    {
        dificuldade = GameObject.FindAnyObjectByType<ControlaDificuldade>();
    }
    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro <= 0)
        {
            GameObject.Instantiate(this.obstaculo, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoParaGerarFacil, tempoParaGerarDificil, dificuldade.Dificuldade);
        }
    }
}
