using UnityEngine;

public class FishingController : MonoBehaviour
{
    public FishSpawner spawner;
    public GameObject hook;

    void Update()
    {
        // Example: check if hook touches a fish
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tried");
            Collider2D hit = Physics2D.OverlapPoint(hook.transform.position);
            if (hit && hit.TryGetComponent(out FishBehaviour fish))
            {
                CatchFish(fish);
                Debug.Log("Caught");
            }
        }
    }

    void CatchFish(FishBehaviour fish)
    {
        FishData caught = fish.GetData();
        Destroy(fish.gameObject);

        // Transition to date phase
    }
}
