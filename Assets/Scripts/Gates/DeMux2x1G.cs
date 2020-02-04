using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeMux2x1G : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool[] Logic(bool inD, bool inX)
    {
        bool NotX = NotG.Logic(inX);
        bool D_and_NotX = AndG.Logic(inD, NotX);
        bool D_and_X = AndG.Logic(inD, inX);
        bool[] outBool = new bool[2];
        outBool[0] = D_and_NotX;
        outBool[1] = D_and_X;
        return outBool;
    }
}
