using System;
using DefaultNamespace;
using UnityEngine;

public class Pipe : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out _) == true)
        {
            ScoreManager.Instance.SetScore(1);
        }
    }
}
