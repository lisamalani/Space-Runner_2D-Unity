using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<10; i++)
        {
            SpawnCoin();
        }
        
    }
    void SpawnCoin()
    {
        Vector3 randomPosition = new Vector3(x:Random.Range(-10f,10f), y:0,z:Random.Range(-10f,10f));
        randomPosition = transform.position + randomPosition;
        Instantiate(coinPrefab, randomPosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
