using UnityEngine;

public class GazeActivator : MonoBehaviour
{
    [SerializeField] private SimpleActivator activator;

    private bool lastState = false;

    public void LookingAtObject(bool looking)
    {
        if (lastState != looking)
        {
            activator.ToggleEffect(looking);
            lastState = looking;
        }
    }
}