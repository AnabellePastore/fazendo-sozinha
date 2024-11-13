using UnityEngine;

public class exercício_01 : MonoBehaviour



{


    //    1. (Verificação de pontos de vida) Um personagem perde pontos
    //de vida após uma batalha.Verifique se ele ainda está vivo.Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contrário, "Game Over"

    [SerializeField] int VidaHeroi = 100;
    [SerializeField] int Dano = 0;
    string resultado;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (VidaHeroi > Dano)
        {
            resultado = "personagem vivo";
            print (resultado);
        }
        else if(VidaHeroi < Dano )
        {
            resultado = "Game Over";
            print(resultado);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
