using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaCena : MonoBehaviour
{
    private ControlaUI telaGameOver;
    public ControlaPontos pontuacao;
    

   

    public void Start()
    {
        telaGameOver = GameObject.FindAnyObjectByType<ControlaUI>();
        pontuacao = GameObject.FindAnyObjectByType<ControlaPontos>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        pontuacao.SalvarRecorde();
        telaGameOver.AtualizarRecorde();
        telaGameOver.TelaGameOver();
    }

    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FullHD");
    }

    public void Sair ()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


}
