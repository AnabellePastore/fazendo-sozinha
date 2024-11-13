using UnityEngine;

public class ex1 : MonoBehaviour
{
    //    1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.

    int i;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= 5; i++) 
        {
            print(i);
        }
        print("Início da partida!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
