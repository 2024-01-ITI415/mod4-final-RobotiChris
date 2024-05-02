using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerMat : MonoBehaviour
{
    public Material flickMat;
    public float numberWang;
    // Start is called before the first frame update
    void Start()
    {
        flickMat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        numberWang = Random.Range(0f, 1f);
        

        if (numberWang <= 1f)
            flickMat.SetColor("_EmissionColor", Color.white);
        else
            flickMat.SetColor("_EmissionColor", Color.black);
    }
}
