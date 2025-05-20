using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditionFase1 : MonoBehaviour
{
    public Slider progressBar;

    public int pontuacao = 0;
    public List<GarrafaControler> garrafaController;

    public bool fimFase = false;
    public GameObject pnlVitoria;

    public SoundManager soundManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Encontra todos os objetos com a tag "DragAndRotate"
        GameObject[] objetosComTag = GameObject.FindGameObjectsWithTag("DragAndRotate");

        // Preenche a lista 'scriptControllers' com os scripts encontrados
        foreach (var objeto in objetosComTag)
        {
            // Adiciona o script 'GarrafaControler' de cada objeto encontrado na lista
            GarrafaControler controler = objeto.GetComponent<GarrafaControler>();
            if (controler != null)
            {
                garrafaController.Add(controler);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        pontuacao = 0;

        foreach (var garrafa in garrafaController)
        {
            pontuacao += (int)garrafa.qtdAgua;
        }

        progressBar.value = pontuacao;

        //FIM DA FASE
        if (!fimFase && TodasGarrafasVazias())
        {
            fimFase = true;
            pnlVitoria.SetActive(true);
            soundManager.SomVictory();
        }
        
    }

    bool TodasGarrafasVazias()
    {
        foreach (var garrafa in garrafaController)
        {
            if (!garrafa.vazio) //Se alguma nao estiver vazia
            {
                return false;
            }
        }
        return true; //Todas estao vazias
    }
}
