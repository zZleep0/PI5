using UnityEngine;
using System.Collections.Generic;

public class PartColision : MonoBehaviour
{
    public WinConditionFase2 winCon;

    public GameObject mosquitoPart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        //Debug.Log("colidiu com " + other.name);
        if (other.CompareTag("Mosquito"))
        {
            Debug.Log("hitou mosquito");
            winCon.pontos++;
            Instantiate(mosquitoPart, other.transform.position, Quaternion.identity);
            Destroy(other);
        }
    }
}
