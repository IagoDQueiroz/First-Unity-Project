using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarDiamantes : MonoBehaviour
{
    [SerializeField] GameObject diamantePrefab;
    private int totalDiamantes = 5;
    [SerializeField] private Transform[] pontosDeSpawn;
    void Start()
    {
        for(int i = 0; i < totalDiamantes; i++)
        {
            int randomIndex = Random.Range(0,pontosDeSpawn.Length);
            Instantiate(diamantePrefab, pontosDeSpawn[randomIndex].position, Quaternion.identity);
        }

    }
}
