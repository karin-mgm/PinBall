using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{
    Material myMaterial;

    private float minEmission = 0.2f;

    private float magEmission = 2.0f;

    private int degree = 0;

    private int speed = 5;

    Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultColor = Color.yellow;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
        }

        this.myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor ("_EmissionColor", this.defaultColor*minEmission);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission); //「Mathf.Deg2Rad」は、度数に掛けることでラジアンに変換できます。

            myMaterial.SetColor ("_EmissionColor", emissionColor);

            this.degree -= this.speed;

        }
    }

    void OnCollisionEnter(Collision other) //衝突時に呼ばれる関数,自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる
    {
        this.degree = 180;
    }
}
