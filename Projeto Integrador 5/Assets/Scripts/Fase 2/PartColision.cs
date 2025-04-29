using UnityEngine;
using System.Collections.Generic;

public class PartColision : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        //Debug.Log("colidiu com " + other.name);
        if (other.CompareTag("Mosquito"))
        {
            Destroy(other);
            Debug.Log("hitou mosquito");
        }
    }
}
