using System;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class exercício_9 : MonoBehaviour

{

    //    9. (Placar final) Crie um script que lê o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos três
    //resultados possíveis aconteceu: vitória do time A, vitória do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi “um empate emocionante”.

    [SerializeField] int placarTimeA;
    [SerializeField] int placarTimeB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (placarTimeA > placarTimeB)
        {
            print("vitória do Time A");
        }
        else if(placarTimeB > placarTimeA)
        {
            print("vitória do Time B");
        }
        else
        {
            if(placarTimeA > 3 && placarTimeB > 3)
            {
                print("Foi um empate emocionante");

            }
            else
            {
                print("Foi um empate!");
            }
        }

    } 
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
