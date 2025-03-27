using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GerenciarRecord : MonoBehaviour
{
    public static void SalvarTempoPartida(float tempo)
    {
        float recordAtual = PlayerPrefs.GetFloat("TempoDePartida");
        
        if(recordAtual > 0)
        {
            if(tempo < recordAtual)
            {
                PlayerPrefs.SetFloat("TempoDePartida", tempo);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("TempoDePartida", tempo);
        }
    }

    public static float  GetRecordeTempoDePartida()
    {
        return PlayerPrefs.GetFloat("TempoDePartida");
    }
}
