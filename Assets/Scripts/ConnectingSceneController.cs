using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ConnectingSceneController : MonoBehaviour
{
    public Text message;

    private GameClient client;

    // Start is called before the first frame update
    void Start()
    {
        message.text = "Connecting...";

        client = GameClient.Instance;

        client.OnConnect += OnConnect;
        client.OnJoin += OnJoin;

        if (!client.Connected)
        {
            client.Connect();
        }
        else
        {
            OnConnect(this, null);
        }
    }

    // Update is called once per frame
    void OnConnect(object sender, EventArgs e)
    {
        message.text = "Finding a game...";

        if (!client.Joined)
        {
            client.Join();
        }
        else
        {
            OnJoin(this, null);
        }
    }

    void OnJoin(object sender, EventArgs e)
    {
        message.text = "Joined! Finding table ...";
    }
}
