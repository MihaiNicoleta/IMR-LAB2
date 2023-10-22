using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshPro scoreText;
    public GameObject ball;
    private Vector3 initialBallPosition;
    private float score = 0;
    public AudioSource audioSource;

    private void Start()
    {
        initialBallPosition = ball.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            float distance = Vector3.Distance(initialBallPosition, ball.transform.position);
            float distanceScore = Mathf.Round(distance * 1000.0f) / 100.0f;
            score += distanceScore;
            UpdateScoreUI();
            initialBallPosition = ball.transform.position;
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();

        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public Vector3 GetBallPosition()
    {
        return ball.transform.position;
    }
}
