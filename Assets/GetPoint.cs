using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour
{

    private GameObject GetPointText;
    private int getpoint = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.GetPointText = GameObject.Find("GetPointText");
        
    }


    // Update is called once per frame
    void Update()
    {

       // this.GetPointText.GetComponent<Text>().text = getpoint;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ( "SmallStarTag"))
        {
            getpoint += 1;
            Debug.Log(getpoint);

        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            getpoint += 2;
            Debug.Log(getpoint);

        }
        else if (collision.gameObject.CompareTag("SmallCloudTag"))
        {
            getpoint += 3;
            Debug.Log(getpoint);
        }
        else if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            getpoint += 4;
            Debug.Log(getpoint);
        }

    }

    

}
