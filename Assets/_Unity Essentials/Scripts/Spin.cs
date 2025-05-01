using UnityEngine;

public class SpinAndDisappear : MonoBehaviour
{
    public float spinSpeed = 100f;
    public string targetTag = "Player"; // Set this to match the tag of the object that should destroy this

    void Update()
    {
        // Spin the object
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Only destroy if the object has the correct tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }
    }
}
