using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

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
}