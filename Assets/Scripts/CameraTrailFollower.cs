using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class CameraTrailFollower : MonoBehaviour
{
    private SplineAnimate spline;
    private bool holdingSpline = false;
    [SerializeField] private bool followSpline = false;

    void Start()
    {
        spline = GetComponent<SplineAnimate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (followSpline)
        {
            if (!holdingSpline)
            {
                if (!spline.IsPlaying)
                {
                    spline.Restart(true);
                }
            }
            
            holdingSpline = true;
        }
        else
        {
            holdingSpline = false;
            spline.Pause();
        }
    }
}
