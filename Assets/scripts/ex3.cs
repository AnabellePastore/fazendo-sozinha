using UnityEngine;

public class ex3 : MonoBehaviour
{

    //3. (C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    // cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.

    [SerializeField] int totalMoeda = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fase = 1; fase <= 10; fase++)
        {
            //totalMoeda = totalMoeda + 3;
            totalMoeda += 3;

            print("O total de moedas at� agora �: " + totalMoeda);
        }

        print("Total de moedas: " + totalMoeda);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
