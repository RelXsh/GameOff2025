using UnityEngine;

public class FishBehaviour : MonoBehaviour
{
    private FishData data;
    private float speed;
    private int direction; // -1 = left, +1 = right

    public void Initialize(FishData fishData, bool goRight)
    {
        data = fishData;
        speed = Random.Range(1f, 3f);
        direction = goRight ? 1 : -1;

        // Flip sprite visually
        GetComponent<SpriteRenderer>().flipX = goRight;
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        // Despawn when off screen
        if (Mathf.Abs(transform.position.x) > 12f)
            Destroy(gameObject);
    }

    public FishData GetData() => data;
}
