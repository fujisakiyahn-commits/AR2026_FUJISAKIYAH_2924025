using UnityEngine;

public class PulseScale : MonoBehaviour
{
    public float speed = 2f;
    public float minScale = 0.8f;
    public float maxScale = 1.2f;

    // The Update method must be inside the class braces
    void Update()
    {
        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f;
        float s = Mathf.Lerp(minScale, maxScale, t);
        transform.localScale = Vector3.one * s;
    }
} // This brace now properly closes the class at the end
