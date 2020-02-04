using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux16C : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool[] Logic(bool[] inA, bool[] inB, bool inX)
    {
        if (inA.Length != 16 || inB.Length != 16)
        {
            Debug.Log("Wrong input to Not16");
            Application.Quit();
        }

        bool[] output = new bool[16];
        for (int i = 0; i < 16; i++)
        {
            output[i] = Mux2x1G.Logic(inA[i], inB[i], inX);
        }

        return output;
    }
}
