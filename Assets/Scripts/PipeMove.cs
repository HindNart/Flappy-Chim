using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;
    private GameObject deletePoint;
    private float width;

    private void Awake()
    {
        deletePoint = GameObject.FindGameObjectWithTag("Bg");
    }

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
