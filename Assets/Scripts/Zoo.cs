using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Zoo : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();

    void Start()
    {
        // animals.Add("Snake");
        //animals.Remove("Gorilla");

        //string firstAnimal = animals[3];
        // Debug.Log(firstAnimal);

        //for(int i = 0; i < animals.Count; i++)
        // {
        //     string currentAinmal = animals[i];
        //     Debug.Log(currentAinmal);
        // }

        //animals.Clear();

        Animal newCat = new Animal("cat", "tiger", 5);
        animals.Add(newCat);

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i].name);
        }

        int x = 0;
        float f = 1f;
        string s = "";   

        //cobstructor: method that establishes te initial valies of 
        //more complicated data type(structs, classes, )
        Vector3 v = new Vector3(0,0,0);
        Color c = new Color(0.5f, 0.5f, 1);
        Vector3 v1 = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class Animal
    {
        public string type;
        public string name;
        public int age;
        public Color colour;
        public float size;
        public string sex;

        public Animal(string inType, string inName, int inAge)
        {
            type = inType;
            name = inName;
            age = inAge;

        }
    }
}
