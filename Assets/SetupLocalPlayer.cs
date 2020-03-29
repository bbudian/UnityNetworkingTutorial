﻿using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
            GetComponent<PlayerController>().enabled = true;
        else
            GetComponent<PlayerController>().enabled = false;
    }
}
