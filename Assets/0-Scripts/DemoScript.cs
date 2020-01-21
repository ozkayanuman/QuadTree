﻿using System.Collections.Generic;
using UnityEngine;
using Peril.Physics;

public class DemoScript : MonoBehaviour
{

    public enum CollisionSystemType
    {
        Brute,
        QuadTree
    }

    public DemoPhysicsBody DemoPhysicsBody;

    [Header("CollisionSystem Settings")]
    public CollisionSystemType CSType;
    public int MaxBodies;

    [Header("QuadTree Settings")]
    public Vector2 WorldSize = new Vector2(200, 200);
    public int BodiesPerNode = 6;
    public int MaxSplits = 6;

    public QuadTree _quadTree;
    private List<IQuadTreeBody> _quadTreeBodies = new List<IQuadTreeBody>();
    private CollisionSystemQuadTree _csQuad;
    private CollisionSystemBrute _csBrute = new CollisionSystemBrute();

    private void Start()
    {
        //Checking game objects tag. Because we want to instantiate to main object(DemoPhysicsBody)
        if (gameObject.CompareTag("Generator"))
        {
            MaxBodies = UIContoller.uIContoller.MaxBodies;
            _quadTree = new QuadTree(new Rect(0, 0, WorldSize.x, WorldSize.y), BodiesPerNode, MaxSplits);
            _csQuad = new CollisionSystemQuadTree(_quadTree);

            //Instantiating game objects
            for (int i = 0; i < MaxBodies; i++)
            {
                InstantiateObj();

            }
        }
    }

    private void Update()
    {
        if (gameObject.CompareTag("Generator"))
        {
            switch (CSType)
            {
                case CollisionSystemType.Brute:
                    _csBrute.Step();
                    break;
                case CollisionSystemType.QuadTree:
                    _csQuad.Step();
                    break;
            }

            // refresh QuadTree each frame if bodies can move
            _quadTree.Clear();
            foreach (var b in _quadTreeBodies)
            {
                _quadTree.AddBody(b);
            }
        }

    }

    private void OnDrawGizmos()
    {
        if (_quadTree == null) return;
        _quadTree.DrawGizmos();
    }

    /// <summary>
    /// Instantiate Method
    /// </summary>
    public void InstantiateObj()
    {
        if (DemoPhysicsBody == null)
        {
            DemoPhysicsBody = Resources.Load<DemoPhysicsBody>("Prefabs/DemoPhysicsBody") as DemoPhysicsBody;
        }
        var body = GameObject.Instantiate<DemoPhysicsBody>(DemoPhysicsBody);
        body.gameObject.tag = "instantiated";
        body.health = 5;
        body.transform.position = new Vector3(Random.Range(0, WorldSize.x), 0, Random.Range(0, WorldSize.y));
        _csBrute.AddBody(body);// add body to CollisionSystemBrute
        _csQuad.AddBody(body);
        _quadTree.AddBody(body); // add body to QuadTree
        _quadTreeBodies.Add(body);
    }

    /// <summary>
    /// Instantiate Method with a value.
    /// </summary>
    /// <param name="aValueObject"></param>
    public void InstantiateObj(int aValueObject)
    {
        for (int i = 0; i < aValueObject; i++)
        {
            InstantiateObj();
        }
    }

}