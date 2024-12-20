using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f; //ボールが見える可能性のあるz軸の最小値

    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {

            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
