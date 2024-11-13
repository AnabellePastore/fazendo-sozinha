using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class laço_de_Repetição : MonoBehaviour
{
    // For : é utilizado quando se sabe a quantidade de repetições
    //While ou DoWhile : é utilizado quando não se sabe a quantidade de repetições
    // Foreach : usado em lista ou arrays, para executar uma operação para cada item da lista 
    //Array : é uma lista



    int x = 0; //While
    int y = 10; //DoWhile 


    //Criando uma lista de números inteiros chamada nums
    List<int> nums = new List<int>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(inicializador; condição; incremento/decremento)
        //for(int i = 0; i <= 10; i++)
        //{
        //    //if(i == 5)
        //    //{
        //    //    break;
        //    //}

        //    if (i == 6)
        //    {
        //        continue;
        //    }

        //    print(i);
        //}

        //While
        //while (x<=10)
        //{
        //    print(x);
        //    x++;
        //}

        //Do While
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);

        //num[0]++;

        //print(num[0]);

        //string[] nomes;

        //nomes = new string[5];
        //nomes[0] = "Tadola";

        //print(nomes[1]);

        //--------------------------------------------------------------------

        //adiciona elementos á lista nums
        nums.Add(1); //indice 0
        nums.Add(2); //indice 1
        nums.Add(3); //indice 2
        nums.Add(4); //indice 3 ...
        nums.Add(4);
        nums.Add(5);
        nums.Add(6);

        //remove o primeiro valor "4" encontrado na lista (indice 3)
        nums.Remove(4);
        //ordena os elementos da lista em ordem crescente 
        nums.Sort();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 