using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SendController: MonoBehaviour
{
    // Start is called before the first frame update
    public InputField input;
    [DllImport("__Internal")]
    private static extern void SendTranscationFromUnity(string address, double amount);
    void Start()
    {
        GameObject.Find("Button").GetComponent<Button>().onClick.AddListener(Transcation);
        input = GameObject.Find("InputField").GetComponent<InputField>();
        input.text = "0xf8331f18a7106bF6B9C0847b3BbC5B6180806A2C";
    }
    void Transcation()
    {
        Debug.Log("click");
        if (input.text.Length == 42)
        {
            #if UNITY_EDITOR
                Debug.Log($"address:{input.text} amount:{1e15}");
            #else
                SendTranscationFromUnity(input.text, 1e15);
            #endif
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
