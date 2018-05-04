using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ChatClient : NetworkBehaviour {

    public GameObject balloon;
    public Transform ChatRoom;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            if (isServer)
                return;

            Destroy(gameObject);
        }
    }

    struct ChatData
    {
        public string text;
        public GameObject gob;
    }

    [Command]
    public void CmdSendToInfo(string _text, GameObject _gob)
    {
        ChatData data = new ChatData()
        {
            text = _text,
            gob = _gob
        };

        SpreadToClient(data);
    }

    void SpreadToClient(ChatData _data)
    {
        var myballoon = Instantiate(balloon, ChatRoom);
        myballoon.GetComponent<BalloonData>().DataOfBalloon(_data.text, _data.gob);
        NetworkServer.Spawn(myballoon);
    }
}
