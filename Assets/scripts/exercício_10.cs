using UnityEngine;
using static UnityEditor.Progress;

public class exercício_10 : MonoBehaviour
{

    //    10. (Itens do inventário) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, poções, ou power-ups)
    //que têm efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.


    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocaoVida = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                moeda++;
                print("moeda coletada" + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("escudo ativo");
                break;

            case "Poção":
                pocaoVida = true;
                print("Poção de cida coletada");
                break;
            default:
                print("Valor incorreto");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
