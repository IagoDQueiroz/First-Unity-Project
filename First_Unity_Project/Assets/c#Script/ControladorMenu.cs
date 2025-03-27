using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    [SerializeField] TMP_Text recordText;

    public void Start()
    {
      float record = GerenciarRecord.GetRecordeTempoDePartida();
        if(record > 0)
        {
            recordText.text = "Melhor Tempo: " + record.ToString("F2") + "s";
        }
        else
        {

        }
    }
    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }
   
    public void SairDoJogo()
    {
        Application.Quit();
    }
}
