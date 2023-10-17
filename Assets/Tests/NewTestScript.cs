using NUnit.Framework;
using UnityEngine;
using UnityEditor.SceneManagement;

public class NewTestScript
{

    [SetUp]
    public void ResetScene()
    {
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
    }

    [Test]
    public void SimpleTest()
    {
        bool isActive = false;

        Assert.AreEqual(false, isActive);
    }
    // 
    [Test]
    public void CatchingErrors()
    {

        GameObject gameObject = new GameObject("test");

        Assert.Throws<MissingComponentException>(
            () => gameObject.GetComponent<Rigidbody>().velocity = Vector3.one
        );

    }
}