using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int score;

    private void start()
    {
        score = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject.transform.parent.gameObject);
            score++;

            Debug.Log($"Score: {score}");
        }
    }
}