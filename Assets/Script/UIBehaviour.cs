using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

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
    }
}