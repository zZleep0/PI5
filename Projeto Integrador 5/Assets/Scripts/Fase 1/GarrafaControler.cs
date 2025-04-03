using UnityEngine;

public class GarrafaControler : MonoBehaviour
{
    public float qtdAgua = 20f;
    public ParticleSystem aguaParticula;

    public float rotacaoZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aguaParticula = GetComponentInChildren<ParticleSystem>();
        aguaParticula.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rotacaoZ = transform.eulerAngles.z;

        // Usa transform.eulerAngles para acessar a rotação de Euler
        if (rotacaoZ >= 135 && rotacaoZ <= 225/* && qtdAgua > 0*/) // Ajuste do intervalo para evitar inconsistências de rotação
        {
            qtdAgua = qtdAgua - Time.deltaTime * 2;
            aguaParticula.gameObject.SetActive(true);
            Debug.Log("Está derramando água");



        }
        else
        {
            aguaParticula.gameObject.SetActive(false);
            Debug.Log("Não está derramando água");
        }
    }
}
