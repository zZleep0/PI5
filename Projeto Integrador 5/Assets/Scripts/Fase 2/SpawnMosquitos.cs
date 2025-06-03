using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawnMosquitos : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject mosquitoPrefab;

    public WinConditionFase2 winCon;
    public bool canSpawn = true; //StopCoroutine nao esta funcionando entao usando este xd

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PrimeiroSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (winCon.pontos >= 10)
        {
            Debug.Log("parou");
            canSpawn = false;
            StopCoroutine(SpawnAleatorio());
        }
    }

    public IEnumerator PrimeiroSpawn()
    {
        yield return new WaitForSeconds(3);
        Instantiate(mosquitoPrefab, spawnPoints[0]);
        StopCoroutine(PrimeiroSpawn());

        StartCoroutine(SpawnAleatorio());
        
    }

    public IEnumerator SpawnAleatorio()
    {
        yield return new WaitForSeconds(3);

        Instantiate(mosquitoPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)]);

        if (canSpawn)
            StartCoroutine(SpawnAleatorio());

    }
}
