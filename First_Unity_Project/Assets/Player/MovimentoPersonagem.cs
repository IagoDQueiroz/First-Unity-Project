using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPersonagem : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float speed;
    private Vector3 gravidade = new Vector3(0, -9.81f, 0);

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoHorizontal, 0, movimentoVertical);
        
        characterController.Move(movimento.normalized * speed * Time.deltaTime);
        characterController.Move(gravidade * Time.deltaTime);

        if(movimento != Vector3.zero)
        {
            Quaternion rotacaoAlvo = Quaternion.LookRotation(movimento);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacaoAlvo, Time.deltaTime * 10f);
        }
    }

    
}
