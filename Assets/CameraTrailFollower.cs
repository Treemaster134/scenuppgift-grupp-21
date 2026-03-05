using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class CameraTrailFollower : MonoBehaviour
{
    private SplineAnimate spline;
    private InputAction splineAction;
    private bool holdingSpline = false;

    void Start()
    {
        splineAction = InputSystem.actions.FindAction("Spline");
        spline = GetComponent<SplineAnimate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (splineAction.IsPressed())
        {
            if (!holdingSpline)
            {
                if (!spline.IsPlaying)
                {
                    spline.Restart(true);
                }
                else
                {
                    spline.Pause();
                }
            }
            
            holdingSpline = true;
        }
        else
        {
            holdingSpline = false;
        }
    }
}
