using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float velocity = 5700;
    private AudioSource audioSource;

    private ScoreController scoreController;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        rb2D.constraints = RigidbodyConstraints2D.FreezePositionY;

        scoreController = FindObjectOfType<ScoreController>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
            if (Input.GetTouch(0).phase == TouchPhase.Began)
                setMovement();
        if (Input.GetMouseButtonDown(0))
            setMovement();

    }
    void setMovement()
    {
        if ((rb2D.constraints & RigidbodyConstraints2D.FreezePositionY) == RigidbodyConstraints2D.FreezePositionY)
        {
            rb2D.constraints = RigidbodyConstraints2D.None;
            rb2D.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

        rb2D.velocity = new Vector2(0, velocity);
        audioSource.Play();

        scoreController.ShowScore();
    }
}
