using UnityEngine;

public class SpillWater : MonoBehaviour
{
    public float qtdAgua = 20f;

    //public float rotacaoZ;
    public ParticleSystem aguaParticula;

    public float rotacaoX;

    public bool vazio = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aguaParticula = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        rotacaoX = transform.eulerAngles.x; // Usa transform.eulerAngles para acessar a rotação de Euler

        var mainmodule = aguaParticula.main;

        // Usa transform.eulerAngles para acessar a rotação de Euler
        if (rotacaoX >= 45 && rotacaoX <= 135 || rotacaoX <= 315 && rotacaoX >= 225) // Ajuste do intervalo para evitar inconsistências de rotação
        {
            qtdAgua = qtdAgua - Time.deltaTime * 2;

            mainmodule.startLifetime = 3f;

            Debug.Log("Está derramando água");


        }
        else
        {
            mainmodule.startLifetime = 0f;

            Debug.Log("Não está derramando água");
        }

        if (qtdAgua <= 0)
        {
            qtdAgua = 0;
            vazio = true;
        }
    }
}
