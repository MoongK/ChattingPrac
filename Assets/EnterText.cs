using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterText : MonoBehaviour {

    public GameObject myClient;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            InputData();
    }

    void InputData()
    {
        myClient.GetComponent<ChatClient>().CmdSendToInfo(transform.Find("Text").GetComponent<Text>().text, myClient);
        transform.Find("Text").GetComponent<Text>().text = string.Empty;
    }
}
