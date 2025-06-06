using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;
    private GameObject deletePoint;
    private float width;

    private void Start()
    {
        deletePoint = GameObject.FindGameObjectWithTag("Bg");
        width = deletePoint.GetComponent<Renderer>().bounds.size.x;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -width)  // Khi đường ống ra khỏi màn hình thì hủy
        {
            FindAnyObjectByType<ObjectPool>().ReturnObject(gameObject);
        }
    }
}
