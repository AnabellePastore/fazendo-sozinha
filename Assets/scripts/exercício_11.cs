using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class exercício_11 : MonoBehaviour
{
    //    11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (estado)
        {
            case 1:
                print("precisa de ajuda?");
                break;

            case 2:
                print("você parece acabado!");
                break;

            case 3:
                print("é por ali");
                break;

            case 4:
                print("ME AJUDE PORFAVOR!!!");
                break;

            case 5:
                print("oque você me oferece em troca?");
                break;

            default:
                print("Não tenho nada a dizer sobre isso!");
                break;
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
