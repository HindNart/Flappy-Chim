using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            ScoreManager.Instance.AddScore();
            AudioManager.Instance.PlayPointSound();
        }
    }
}
