using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawnMosquitos : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject mosquitoPrefab;
    public bool canRandom = false;
    public float timerSpawn = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PrimeiroSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        timerSpawn -= Time.deltaTime;
        if (timerSpawn <= 0)
        {
            timerSpawn = 2;
        }

        if (canRandom && timerSpawn == 2)
        {
            StartCoroutine(SpawnAleatorio());
        }
    }

    public IEnumerator PrimeiroSpawn()
    {
        yield return new WaitForSeconds(2);
        Instantiate(mosquitoPrefab, spawnPoints[2]);
        canRandom = true;
    }

    public IEnumerator SpawnAleatorio()
    {
        yield return new WaitForSeconds(2);
        Instantiate(mosquitoPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)]);
    }
}
