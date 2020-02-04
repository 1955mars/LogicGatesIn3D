using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeMux4Way : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool[] Logic(bool inD, bool[] inX)
    {
        if(inX.Length != 2)
        {
            Debug.Log("Wrong input to Not16");
            Application.Quit();
        }

        bool[] out1 = DeMux2x1G.Logic(inD, inX[1]);
        bool[] out2 = DeMux2x1G.Logic(out1[0], inX[0]);
        bool[] out3 = DeMux2x1G.Logic(out1[1], inX[0]);

        bool[] out4 = new bool[4];

        out4[0] = out2[0];
        out4[1] = out2[1];
        out4[2] = out3[0];
        out4[3] = out3[1];

        return out4;
    }
}
