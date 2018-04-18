using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemy;
    public Transform spawnPoint;

    public float waveTimer = 5f;

    private float countdown = 2f;
    private int waveNum = 0;

    public Text waveCountdown;

    private void Update()
    {
        if(countdown <= 0)
        {
            StartCoroutine(SpawnWave());

            countdown = waveTimer;
        }

        countdown -= Time.deltaTime;

        waveCountdown.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveNum++;

        for (int i = 0; i < waveNum; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
