using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace livingObjects
{
    public class Hero
    {
        public int Health;
        public int Stamina;
        public int Exp;
        public int Dmg;
        public bool Immortality;
        public const int moveSpeed  = 10;
        public const int jumpHeight  = 7;
    }

    public class Mushroom
    {
        public int Health;
        public double Size;
        public int Dmg;
        public double Speed;
        public const int AgressiveRange  = 5;
    }

    public class Boss
    {
        public const int Health = 100;
        public const int Dmg = 100;
        public bool Immortality;
    }
}
/*public class livingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
