using UnityEngine;

public class ex7 : MonoBehaviour
{

    //7. (Maior n�mero em uma lista) Dada uma lista de n�meros,
    //encontre o maior valor.

    int[] numeros = { -3, -5, -7, -10, -68, -23, -71, -18, -97, -1 };
    int maior;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maior = numeros[0];

        foreach (var item in numeros)
        {

            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior n�mero �: " + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
