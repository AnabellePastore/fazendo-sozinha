using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercício_5 : MonoBehaviour
{

    //    5. (Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int pontos;
    string resultado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pontos > 50)
        {
            resultado = "Missão bem-sucedida";
            print(resultado);
        }
       else if (pontos <= 50)
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
