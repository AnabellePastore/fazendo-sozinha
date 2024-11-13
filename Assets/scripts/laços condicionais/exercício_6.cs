using UnityEngine;

public class exercício_6 : MonoBehaviour

{

    //    6. (Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.


    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (guerreiro == true && mago == false)
        {
            print("guerreiro escolhido");
        }
        else if (guerreiro == false && mago == true)
        {
            print("mago escolhido");
        }
        else if (guerreiro == true && mago == true)
        {
            print("você só pode escolher um ");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
