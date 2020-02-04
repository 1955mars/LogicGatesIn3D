using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool Logic(bool inA, bool inB)
    {
        bool notA = NotG.Logic(inA);
        bool notB = NotG.Logic(inB);
        bool AAnd_NotB = AndG.Logic(inA, notB);
        bool BAnd_NotA = AndG.Logic(inB, notA);
        return OrG.Logic(AAnd_NotB, BAnd_NotA);
    }
}
