using UnityEngine;

public class LightCuller : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float maxDistance;
    private Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }
    
    void FixedUpdate()
    {
        if (Vector2.Distance((Vector2)target.position, (Vector2)transform.position) < maxDistance)
        {
            light.enabled = true;
        }
        else
        {
            light.enabled = false;
        }
    }
}
