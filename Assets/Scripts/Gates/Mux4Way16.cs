using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux4Way16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool[] Logic(bool[] inA, bool[] inB, bool[] inC, bool[] inD, bool[] inX)
    {
        if (inA.Length != 16 || inB.Length != 16 || inC.Length !=16 || inD.Length !=16 || inX.Length !=2)
        {
            Debug.Log("Wrong input to Not16");
            Application.Quit();
        }

        bool[] AMux16B = Mux16C.Logic(inA, inB, inX[0]);
        bool[] CMux16D = Mux16C.Logic(inC, inD, inX[0]);

        return Mux16C.Logic(AMux16B, CMux16D, inX[1]);
    }
}
