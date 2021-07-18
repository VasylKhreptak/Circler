using UnityEngine;

public class RandomRotationScript : MonoBehaviour
{
    private float rotationAngle;

    public Vector2 TimeOfRepeatingRange = new Vector2(0f, 1f);
    public Vector2 TimeOfDelayRange = new Vector2(0f, 1f);
    public Vector2 angleRange = new Vector2(-100f, 50f);
    void Start()
    {
        InvokeRepeating("generateNewValues",
        Random.Range(TimeOfDelayRange.x, TimeOfDelayRange.y),
        Random.Range(TimeOfRepeatingRange.x, TimeOfRepeatingRange.y));
    }
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, rotationAngle), Time.deltaTime);
    }
    void generateNewValues()
    {
        rotationAngle = Random.Range(angleRange.x, angleRange.y);
    }

}
