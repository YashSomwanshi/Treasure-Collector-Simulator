using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}