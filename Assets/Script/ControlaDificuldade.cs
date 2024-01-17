using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaDificuldade : MonoBehaviour


{
    public float tempoDificuldadeMaxima;
    private float tempoPassado;
    public float Dificuldade { get; private set; }

    void Update()
    {
        this.tempoPassado += Time.deltaTime;
        this.Dificuldade = tempoPassado / tempoDificuldadeMaxima;
        this.Dificuldade = Mathf.Min(1, this.Dificuldade);
        
    }
}
