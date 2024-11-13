using UnityEngine;

public class exercício_2 : MonoBehaviour
{

    //2. (Detecção de power-up) Ao coletar um power-up, o
    //personagem aumenta sua velocidade.Se o jogador encontrar um
    //power-up, exiba "Power-up Coletado". Caso contrário, exiba
    //"Nenhum power-up encontrado".


    [SerializeField] bool powerUp;
    string resultado; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(powerUp = true)
        {
            resultado = "Power-Up coletado";
            print (resultado);
        }
        else
        {
            resultado = "Nenhum Powe-Up encontrado";
            print(resultado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
