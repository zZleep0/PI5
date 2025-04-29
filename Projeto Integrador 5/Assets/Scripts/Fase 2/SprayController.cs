using UnityEngine;
using System.Collections.Generic;

public class SprayController : MonoBehaviour
{
    public ParticleSystem sprayPart;

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
            mainModule.startLifetime = 2;
            //if (Input.touches[0].phase == TouchPhase.Began)
            //{
            //    mainModule.startLifetime = 2;
            //}
        }
        else
        {
            mainModule.startLifetime = 0;
        }
    }
}
