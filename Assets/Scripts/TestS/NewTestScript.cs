using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Assertions;

public class NewTestScript
{

    public int addTwoNums(int one, int two) {
        return one + two;
    }

    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        UnityEngine.Assertions.Assert.AreNotEqual(addTwoNums(1, 2), 4);
        // Use the Assert class to test conditions
    }

    [Test]
    public void NewTestScriptSimpleNotPasses()
    {
        UnityEngine.Assertions.Assert.AreNotEqual(addTwoNums(1, 2), 3);
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
