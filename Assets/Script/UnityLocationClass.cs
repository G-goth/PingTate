using System.Collections;
using UnityEngine;

public class UnityLocationClass : MonoBehaviour
{
    public string IsEnabledByUserToStringProp
    {
        get{ return Input.location.isEnabledByUser.ToString(); }
    }

    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
    }

    private IEnumerator StartLocation()
    {
        yield break;
    }
}