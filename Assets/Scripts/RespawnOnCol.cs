using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnCol : MonoBehaviour
{
    public float minPos = -25;
    // Update is called once per frame
    void Update()
    {
        float posY = transform.position.y;
        if(posY < minPos)
        {
            UnityEngine.Debug.Log("Me cai.");
            SceneManager.LoadScene("FPS_Parkour");
        }
    }
}
