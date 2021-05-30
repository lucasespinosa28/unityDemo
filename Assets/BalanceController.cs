using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        GameObject.Find("BalanceText").GetComponent<Text>().text = $"Balance: 100 ETH";
        
        
#endif
    }

#if !UNITY_EDITOR
    void EtherBalanceToUnity(string amount)
    {
        GameObject.Find("BalanceText").GetComponent<Text>().text = $"Balance: {amount} ETH";
    }
#endif
    // Update is called once per frame
    void Update()
    {
        
    }
}
