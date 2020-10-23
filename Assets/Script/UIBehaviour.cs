using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class UIBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // スクリプトを取得
        var location = GameObject.FindGameObjectWithTag("GameController").GetComponent<UnityLocationClass>();
        // キャンバスを取得
        var mainCanvas = GameObject.FindGameObjectWithTag("Canvas");
        var isLocateText = mainCanvas.GetComponentInChildren<Text>();


        var updateText = this.UpdateAsObservable()
            .Subscribe(_ => {
                isLocateText.text = location.IsEnabledByUserToStringProp;
                });
    }
}