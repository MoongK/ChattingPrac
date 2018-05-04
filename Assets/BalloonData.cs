using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonData : MonoBehaviour {

    public void DataOfBalloon(string _text, GameObject _ob)
    {
        transform.Find("Text").GetComponent<Text>().text = _text;
    }
}
