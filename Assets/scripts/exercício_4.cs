using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class exercício_4 : MonoBehaviour
{

    //4. (Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".


    [SerializeField] bool pocaoDeVida;
    string resultado;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pocaoDeVida = true)
        {
            resultado = "Usando Poção de Vida";
            print(resultado);
        }
        else 
        {
            resultado = "Poção Indisponível";
            print(resultado);
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
