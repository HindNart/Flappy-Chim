using UnityEngine;

public class FloorMove : MonoBehaviour
{
    public float speed = 2f;             // Tốc độ di chuyển của sàn
    private float groundWidth;           // Chiều dài của sàn
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        groundWidth = GetComponent<Renderer>().bounds.size.x;
    }

    void Update()
    {
        // Di chuyển sàn sang trái
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Khi sàn ra khỏi màn hình, đưa nó về phía sau sprite còn lại
        if (transform.position.x <= startPosition.x - groundWidth)
        {
            transform.position += new Vector3(groundWidth, 0, 0);
        }
    }
}
