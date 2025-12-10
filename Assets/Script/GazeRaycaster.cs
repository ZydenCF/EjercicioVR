using UnityEngine;
using System.Collections.Generic;

public class GazeRaycaster : MonoBehaviour
{
    [SerializeField] private float rayDistance = 8.0f;
    private List<GazeActivator> activators = new List<GazeActivator>();

    private GazeActivator currentGaze;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            GazeActivator gaze = hit.collider.GetComponent<GazeActivator>();

            if (gaze != null)
            {
                if (currentGaze != gaze)
                {
                    if (currentGaze != null)
                        currentGaze.LookingAtObject(false);

                    currentGaze = gaze;
                }

                currentGaze.LookingAtObject(true);
                return;
            }
        }

        // Si no se detecta nada
        if (currentGaze != null)
        {
            currentGaze.LookingAtObject(false);
            currentGaze = null;
        }
    }
}
