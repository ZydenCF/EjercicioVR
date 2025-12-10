using UnityEngine;


public class SimpleActivator : MonoBehaviour
{
    [Header("Assign the Animator")]
    [SerializeField] private Animator myAnimator;

    [Header("Assign the Particle System")]
    [SerializeField] private ParticleSystem myParticles;

    [Header("The animation bool name")]
    [SerializeField] private string boolName = "Play2";

    private bool isActive = false;

    public void ToggleEffect(bool active)
    {
        isActive = active;

        if (myAnimator != null)
        {
            myAnimator.SetBool(boolName, isActive);
        }

        if (myParticles != null)
        {
            if (isActive)
                myParticles.Play();
            else
                myParticles.Stop();
        }
    }
}