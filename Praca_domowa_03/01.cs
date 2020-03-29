using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 01 : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
   
    //deklaracja
    int a= 10;
   float b = 20;
   bool c = false,
   d= true;
   string e = "Programuję w C#", f = "EPG";
   Z4(a,b,c,d,e,f);
   Z5(a,b);
   Z6(e,f);
   Z7(c,d);



  
public void Z4(int a, float b, bool c, bool d, string e, string f ){
        Debug.Log("a: " + a + " b: " + b + " c: " + c +" d: " + d + "e: " + e + " f: " + f);
        }



   public void Z5(int a, float b)
    {
        if (a == b)
            Debug.Log("tak");
        else Debug.Log("nie");


        if (a != b)
            Debug.Log("tak");
        else Debug.Log("nie");


        if (a > b)
            Debug.Log("tak");
        else Debug.Log("nie");


        if (a >= b)
            Debug.Log("tak");
        else Debug.Log("nie");


        if (a < b)
            Debug.Log("tak");
        else Debug.Log("nie");


        if (a <= b)
            Debug.Log("tak");
        else Debug.Log("nie");

    }




    public void Z6(string e, string f)
    {
        if (!e.Equals(f))
            Debug.Log("rozne");

    }

    public void Z7(bool c, bool d)
    {
        Debug.Log("c && d: " + (c && d));
        Debug.Log("c || d: " + (c || d));

    }
   
}