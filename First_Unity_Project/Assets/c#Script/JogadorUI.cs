using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogadorUI : MonoBehaviour
{
    [SerializeField] private TMP_Text txt_DiamantesColetados;
    [SerializeField] private TMP_Text txt_contador;
    [SerializeField] private TMP_Text txt_ContadorFimDeJogo;
    [SerializeField] private GameObject panelFimDeJogo;
    [SerializeField] private GameObject panelPause;
  public void AtualizarDiamantesColetados(int diamantesColetados, int totalDiamantes)
    {
        txt_DiamantesColetados.text = diamantesColetados + "/" + totalDiamantes;
    }

    public void AtualizarContador(float tempo)
    {
        txt_contador.text = tempo.ToString("F1") + "s";
    }

    public void AbrirPanelFimDeJogo()
    {
        panelFimDeJogo.SetActive(true);
        txt_ContadorFimDeJogo.text = txt_contador.text;
    }

    public void pauseJogo()
    {
        panelPause.SetActive(true);

    }
    public void ContinuarJogo()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
    }

    public void SairPartida()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseJogo();
            Time.timeScale = 0;
        }
    }
 
}
