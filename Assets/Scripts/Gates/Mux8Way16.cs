using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux8Way16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool[] Logic(bool[] inA, bool[] inB, bool[] inC, bool[] inD,
        bool[] inE, bool[] inF, bool[] inG, bool[] inH, bool[] inX)
    {
        if (inA.Length != 16 || inB.Length != 16 || inC.Length !=16 || inD.Length !=16 ||
            inE.Length != 16 || inF.Length != 16 || inG.Length != 16 || inH.Length != 16 || inX.Length !=3)
        {
            Debug.Log("Wrong input to Not16");
            Application.Quit();
        }

        bool[] inX1 = new bool[2];
        inX1[0] = inX[0];
        inX1[1] = inX[1];
        bool[] ABCDMux4Way16 = Mux4Way16.Logic(inA, inB, inC, inD, inX1);
        bool[] EFGHMux4Way16 = Mux4Way16.Logic(inE, inF, inG, inH, inX1);

        return Mux16C.Logic(ABCDMux4Way16, EFGHMux4Way16, inX[2]);
    }
}
