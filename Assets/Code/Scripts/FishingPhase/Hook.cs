using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f; // optional smoothing

    void Update()
    {
        // Convert mouse position (screen space) to world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // because we're in 2D

        // Option 1: instant snap
        transform.position = mousePos;

        // Option 2: smooth follow (looks nicer)
        //transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed * Time.deltaTime);
    }
}
