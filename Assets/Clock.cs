using UnityEngine;

/// <summary>
/// Component to display current time on clock object
/// </summary>
public class Clock : MonoBehaviour
{
    //initialise clock hands in inspector
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    //execute code when component awakens
    private void Awake()
    {
        //get local rotation as a quaternion euler
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f);
    }
}
