using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;
    public GameObject deletePoint;
    private float width;

    void Start()
    {
        width = deletePoint.GetComponent<Renderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -width)  // Khi đường ống ra khỏi màn hình thì hủy
        {
            Destroy(gameObject);
        }
    }
}
