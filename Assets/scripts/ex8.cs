using UnityEngine;

public class ex8 : MonoBehaviour
{
    //8. (Reverter uma string) Escreva um programa que inverte uma
    //string usando um loop for.

    string palavra = "anotaramadatadamaratona";

    string invertida = "";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        print("String invertida: " + invertida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}