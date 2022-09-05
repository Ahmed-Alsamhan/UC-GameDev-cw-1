using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tets1 : MonoBehaviour
{
    string heroname = " flash ";
    string villainname = "reverse flash";
    // Start is called before the first frame update
    void Start()
    {
        float herohight = 1.90f;
        int heroage = 20;
        string HeroSuperPower = "speed";

            float villainhight = 1.70f;
        int villainage = 26;
        string villainSuperPower = "speed";

            print("my hero name " + heroname + "my hero hight" + herohight + "my hero age" + heroage + "my hero SuperPower" + HeroSuperPower);
        print("my villain name " + villainname + "my villain hight" + villainhight + "my villain age" + villainage + "my villain SuperPower" + villainSuperPower);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
