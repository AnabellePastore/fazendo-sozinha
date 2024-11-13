using UnityEngine;

public class ex2 : MonoBehaviour
{
    //    (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

    [SerializeField] int dano = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(inicializa; condição; incremento/decremento)
        for (int i = 1; i <= 5; i++)
        {
            print("Ataque " + i + ": Dano " + dano);
            //dano = dano + 2;
            dano += 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
