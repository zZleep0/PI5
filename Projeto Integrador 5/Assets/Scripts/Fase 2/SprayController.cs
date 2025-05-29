using UnityEngine;
using System.Collections.Generic;

public class SprayController : MonoBehaviour
{
    public ParticleSystem sprayPart;
    public GameObject aerosol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sprayPart = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var mainModule = sprayPart.main;

        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            aerosol.SetActive(true);
            mainModule.startLifetime = 2;
            //if (Input.touches[0].phase == TouchPhase.Began)
            //{
            //    mainModule.startLifetime = 2;
            //}
        }
        else
        {
            aerosol.SetActive(false);
            mainModule.startLifetime = 0;
        }
    }
}
