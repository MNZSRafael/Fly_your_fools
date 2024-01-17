using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ControlaUI : MonoBehaviour
{

    public TMP_Text valorRecord;
    public TMP_Text valorPontuacao;
    private ControlaPontos pontuacao;
    public GameObject imagemGameOver;
    private int recorde;
    public Image posicaoMedalha;
    public Sprite medalhaDeOuro;
    public Sprite medalhaDePrata;
    public Sprite medalhaDeBronze;



    private void Start()
    {
        pontuacao = GameObject.FindAnyObjectByType<ControlaPontos>();
    }

    public void AtualizarRecorde()
    {
        this.recorde = PlayerPrefs.GetInt("record");
        this.valorRecord.text = recorde.ToString();
        this.valorPontuacao.text = pontuacao.Pontos.ToString();
        this.TipoDeMedalha();
    }

    public void TelaGameOver()
    {
        imagemGameOver.SetActive(true);
    }

    public void TipoDeMedalha()
    {
        if (pontuacao.Pontos >= recorde - 1)
        {
            posicaoMedalha.sprite = medalhaDeOuro;
        }

        else if (pontuacao.Pontos >= recorde * 0.5)
        {
            posicaoMedalha.sprite = medalhaDePrata;
        }

        else if (pontuacao.Pontos >= recorde * 0.25)

        { posicaoMedalha.sprite = medalhaDeBronze; }

        else

            posicaoMedalha.enabled = false;

    }

    
}
