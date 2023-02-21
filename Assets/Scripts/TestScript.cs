using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public int addTwoNums(int one, int two) {
        return one + two;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(addTwoNums(1, 2) == 3);
        Debug.Log(addTwoNums(1, 2) == 4);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
