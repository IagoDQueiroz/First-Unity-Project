using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPartida : MonoBehaviour
{
    private float contador;
    [SerializeField] private JogadorUI jogadorUI;

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        jogadorUI.AtualizarContador(contador);
    }

    public  void SalvarResultado()
    {
        GerenciarRecord.SalvarTempoPartida(contador);
    }
}
