using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController
{

    NodeView nodeView;
    NodeModel nodeModel;

    public NodeController(NodeView nodeView, NodeModel nodeModel)
    {

        this.nodeView = nodeView;
        this.nodeModel = nodeModel;
        
        initNode();

    }


    void initNode() {
                
        this.nodeModel.gameObject.transform.localPosition = new Vector3(nodeModel.xPos, nodeModel.yPos, 0);
        this.nodeModel.gameObject.transform.localScale = new Vector3(10, 10, 10);
        this.nodeModel.gameObject.GetComponent<Renderer>().material.color = Color.red;

        Rigidbody rb = this.nodeModel.gameObject.AddComponent<Rigidbody>();

    }


    public void moveNode(int x, int y, int z) {

        Rigidbody rb = this.nodeModel.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(x, y, z);

    }
}
