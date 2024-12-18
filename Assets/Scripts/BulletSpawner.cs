using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner: MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 프리팹
    public float spawnRateMin = 0.5f; // 총알 생성 최소주기
    public float spawnRateMax = 3f; // 총알 생성 최대주기

    private Transform target; // 총알을 발사할 대상
    private float spawnRate; // 총알 생성 주기
    private float timeAfterSpawn; // 최근 총알 생성 시점에서 지난 시간

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }

}
