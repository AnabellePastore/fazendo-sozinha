using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    /*
      Operadore relacionais
    == (igual)
    != (diferente)
    >  (maior que)
    <  (menor que)
    <= (menor igual que)
    >= (maior igual que)



    */

    ////string publica, ou seja, aparece na unity
    //public string variavelPublica;
    
    //private string variavelPrivada;
    ////fazer uma string mesmo privada aparecer na unity
    //[SerializeField] int vidaJogador = 10;


    //NUNCA ESQUECER O PONTO E VIRGULA NO FINAL;


    ////classe: 
    ////números inteiros
    ////int vidaJogador = 10;

    ////numeros com virgulas 
    //float velocidadeCarro = 125.5f;
    ////o "f" no final do numero transforma o numero com virgula em compatível com o float

    ////para textos
    //string nomeJogador = "Anabola";

    ////guardar 1 caracter
    //char apelido = 'T';

    ////aspas duplas (" ") para mais de um caracter, pou seja, mais de uma letra
    ////aspas unicas ('') para apenas 1 caracter, ou seja, apenas uma letra

    ////para verdadeiro ou falso
    //bool vivo = true;

    ////nao utilizar numeros primeiro no nome de uma variavel 

    int variavelGlobal;


    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        print(vidaVilao == vidaHeroi); //false
        print(vidaHeroi <= vidaVilao); //true
        print(vidaVilao != vidaHeroi); //true



        //Operador ternario
        // condiçao ? valor a ser atrubuido caso verdadeiro : caso falso]
        //resultado = vidaHeroi < vidaVilao ? "Vida heroi menor" : "Vida heroi maior";
        //print(resultado);
        //int variavelLocal = 10;
        //print(variavelLocal);



        //operadores Logicos
        //&& - e/and
        //|| - ou/or
        //! -  não/not






        //print(variavelGlobal);




        //da pra colocar mais de uma fase

        if(vidaHeroi < vidaVilao)
        {
            resultado = "vida heroi menor";
            print(resultado);

        }
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "vida herois maior";
            print(resultado); 
        }
        else
        {
            resultado = "vida heroi maior";
            print(resultado);
        }





        ////executa e mostra a frase da variavel
        //Debug.Log(vidaJogador);

        //print(velocidadeCarro);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello Word!");
    }
}

