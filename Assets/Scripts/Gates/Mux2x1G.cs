using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux2x1G : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool Logic(bool inA, bool inB, bool inX)
    {
        bool NotX = NotG.Logic(inX);
        bool A_and_NotX = AndG.Logic(inA, NotX);
        bool B_and_X = AndG.Logic(inB, inX);
        return OrG.Logic(A_and_NotX, B_and_X);
    }
}
