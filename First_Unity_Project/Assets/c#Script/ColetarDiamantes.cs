using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColetarDiamantes : MonoBehaviour
{
    [SerializeField] private int diamantesColetados;
    [SerializeField] private JogadorUI jogadorUI;
    [SerializeField]  UnityEvent OnFimDeJogo;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip snd_ColetarDiamantes;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Diamante"))
        {
            hit.gameObject.SetActive(false); // Desativa o objeto imediatamente
            Destroy(hit.gameObject); // Destroi após um pequeno delay
            diamantesColetados += 1;
            jogadorUI.AtualizarDiamantesColetados(diamantesColetados, 5);

            if (diamantesColetados >= 5)
            {
                OnFimDeJogo.Invoke();
            }

            audioSource.PlayOneShot(snd_ColetarDiamantes);
        }
    }


}
