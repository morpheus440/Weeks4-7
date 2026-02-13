using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class BarrelScript : MonoBehaviour
{
    public GameObject knife;
    public List<Knife> knives = new List<Knife>();
    void Start()
    {
        float rand = Random.Range(1f, 5f);
        bool temp = false;

        for (int i = 0; i < 5; i++)
        {
            if(rand == i)
            {
                temp = true;
            }
            Knife newKnife = new Knife(i*20, temp);
            temp = false;
            knives.Add(newKnife);
            Debug.Log(knives[i].height);
        }

       // Debug.Log(knives[0].height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public class Knife
    {
        public float height;
        public bool isRigged;

        public Knife(float inHeight, bool inisRigged)
        {
            height = inHeight;
            isRigged = inisRigged;
        }
    }

}
