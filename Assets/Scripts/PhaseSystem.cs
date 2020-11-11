using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseSystem
{
    private int phaseCount;

    // Start is called before the first frame update
    public PhaseSystem()
    {
        phaseCount = 1;
    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void UpPhase()
    {
        phaseCount++;
    }

    public void ChangePhase()
    {
    }

    public int GetPhaseCount()
    {
        return phaseCount;
    }
}
