using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private int x = 5;
    private float g = 6;
    private string Yeet = "Flying";
    public string Screw = "Sheep";
    int SkalFaktor = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("what");
    }

    // Update is called once per frame
    void Update()
    {
        SkalFaktor = SkalFaktor + 1;
        transform.Rotate(1, 1, 0);
        transform.localScale = new Vector3(SkalFaktor, SkalFaktor, SkalFaktor);
    }

    void RotateObject(int x)
    {

    }
}
