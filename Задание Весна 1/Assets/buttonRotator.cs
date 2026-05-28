using UnityEngine;
using Valve.VR.InteractionSystem; 

public class ButtonRotator : MonoBehaviour
{
    public GameObject objectToRotate;

    private CircularDrive circularDrive;

    private void Start()
    {
        if (objectToRotate != null)
            circularDrive = objectToRotate.GetComponent<CircularDrive>();
    }


    public void OnButtonPress(Hand hand)
    {
        if (circularDrive != null)
        {
            circularDrive.enabled = true;
        }
    }

    public void OnButtonRelease(Hand hand)
    {
        if (circularDrive != null)
        {
            circularDrive.enabled = false;
        }
    }
}