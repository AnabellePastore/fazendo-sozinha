using UnityEngine;

public class ex4 : MonoBehaviour
{

    //4. (Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int pontuacao = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int combo = 1; combo <= 7; combo++)
        {
            //pontuacao = pontuacao + 10;
            pontuacao += 10;
        }

        print("Pontua��o total: " + pontuacao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
