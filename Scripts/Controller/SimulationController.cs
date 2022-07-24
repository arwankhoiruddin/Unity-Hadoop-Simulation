using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationController
{

    public void setTimerState() {

        if (Configs.timeCounter % Configs.nextDuration == 0) {
            Configs.status++;
        }
        
    }

    public int[] generateSpec(int lowerRange, int upperRange) {

        int[] spec = new int[Configs.numNodes];

        if (!Configs.isHomogeneous) {

            for (int i = 0; i < Configs.numNodes; i++) {
                spec[i] = Random.Range(lowerRange, upperRange);
            }

        } else {

            int c = Random.Range(lowerRange, upperRange);
            for (int i=0; i < Configs.numNodes; i++) {
                spec[i] = c;
            }

        }
        return spec;
    }

}
