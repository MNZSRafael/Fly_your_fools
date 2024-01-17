using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlaPontos : MonoBehaviour
{
    public int Pontos { get; private set; }
    public TMP_Text textoParaMudar;
    private AudioSource som;

    private void Awake()
    {
        this.som = this.GetComponent<AudioSource>();
    }


    public void AdicionarPontos()
    {
        Pontos++;
        this.textoParaMudar.text = Pontos.ToString();
        this.som.Play();

        
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("record");
        if (Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("record", Pontos);
            
        }
    }


}
