using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeView
{
    public GameObject gameObject;
    public int xPos;
    public int yPos;

    public NodeView(int x, int y, int z) {

        this.gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        this.gameObject.name = "Node" + Configs.cubeCounter++;
        this.xPos = x;
        this.yPos = y;
        
    }
}
