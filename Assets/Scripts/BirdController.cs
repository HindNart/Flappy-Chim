using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 3f;  // Lực khi bird nhảy lên
    private Rigidbody2D rb;
    private bool isAlive = true;  // Trạng thái của bird
    public float maxRotationAngle = 45f;  // Góc tối đa khi ngóc đầu lên
    public float minRotationAngle = -70f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isAlive && (Input.GetMouseButtonDown(0) || IsTouching()))
        {
            rb.velocity = Vector2.up * jumpForce;
            AudioManager.Instance.PlayFlapSound();
        }

        RotateBird();
    }

    bool IsTouching()
    {
        return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
    }

    void RotateBird()
    {
        float angle;
        if (rb.velocity.y > 0)  // Khi chim bay lên, ngóc đầu lên
        {
            angle = Mathf.Lerp(0, maxRotationAngle, rb.velocity.y / jumpForce);
        }
        else  // Khi chim rơi xuống, chúi đầu xuống
        {
            angle = Mathf.Lerp(0, minRotationAngle, -rb.velocity.y / jumpForce);
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;  // Bird chết khi va chạm
        GameManager.Instance.GameOver();
    }
}
