using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux8Way16Simulator : GateSimulator
{
    public MeshRenderer[] inputA;
    public MeshRenderer[] output;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            //bool[] valueA = new bool[16];
            //bool[] valueB = new bool[16];

            //int temp = counter;
            //int tempCounter = 0;
            //while(true)
            //{
            //    if (temp <= 0)
            //        break;
            //    valueA[tempCounter] = (temp % 2 == 0) ? false : true;
            //    temp = temp / 2;
            //    tempCounter++;
            //}

            //bool[] outp = And16C.Logic(valueA, valueB);

            //for(int i=0; i<16; i++)
            //{
            //    inputA[i].material = valueA[i] ? onMat : offMat;
            //    output[i].material = outp[i] ? onMat : offMat;
            //}

            //counter++;

            //if (counter >= UnityEngine.Mathf.Pow(2,16))
            //{
            //    counter = 0;
            //}

            timeCounter = 0.0f;
        }
        timeCounter += Time.deltaTime;
    }
}
