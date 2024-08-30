using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    [SerializeField] private int x = 5;
    private float g = 6f;
    private string Yeet = "Flying";
    public string Screw = "Sheep";
    float SkalFaktor = 0.1f;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("what");
    }

    // Update is called once per frame
    void Update()
    {
        SkalFaktor = SkalFaktor + 0.1f * Time.deltaTime;
        //transform.Rotate(1, 1, 0);
        transform.localScale = new Vector3(SkalFaktor, SkalFaktor, SkalFaktor);
        //transform.position =
        //transform.localPosition = new Vector3();
    }

    //void RotateObject(int x)
    //{

    //}
}
