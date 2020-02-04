using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Simulate
{
    void StartSimulation(float timePeriod);
    void StopSimulation();

    string SimName();
}