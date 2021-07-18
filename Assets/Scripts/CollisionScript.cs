using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public ParticleSystem playerColisionParticle;
    public ScoreController scoreController;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            playerColisionParticle.transform.position = transform.position;
            playerColisionParticle.Play();
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().ShowRestartMenu(true);

            scoreController.ShowRecord();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "FinishLine")
        {
            FindObjectOfType<GameManager>().CircleComplete((int)scoreController.score);

            scoreController.score += 1;
            scoreController.ShowScore();

            if (scoreController.score > PlayerPrefs.GetInt("Record"))
                PlayerPrefs.SetInt("Record", (int)scoreController.score);
        }
    }
}
