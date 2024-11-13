using UnityEngine;

public class exercício_3 : MonoBehaviour
{
    //3 - (desafio) Considere que o jogo tem um power-up que revive o 
    //personqgem caso ele morra. Caso o jogador morra e tiver
    //coletado um power-up, ele volta a vida com 50% de sua vida total e
    //deve ser exibido a mensagem "Ainda não , vida atual XX". Caso ele
    //não tenha coletado o powe-up exiba "Game Over"



    [SerializeField] bool playerVivo; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(playerVivo == false && powerUp == true)
        { vidaPlayer = vidaPlayer* 0.5;
            print("Ainda não, vida atual " + vidaPlayer);

        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
