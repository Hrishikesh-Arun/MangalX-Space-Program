using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratePart : MonoBehaviour
{
    public GameObject parent;
    public Text ObjName;

    private void Update()
    {
        if (ObjName.text != "")
        {
            parent.name = ObjName.text;
        }
        else
        {
            parent.name = "Test Rocket";
        }
    }

    public void DuplicateTo3D(string objName)
    {
        GameObject obj3d = GameObject.FindGameObjectWithTag(objName);
        GameObject objd = Instantiate(obj3d, new Vector3(0, 17.5f, -214), obj3d.transform.rotation);
        objd.AddComponent<SpaceCraftPart>();
        objd.name = objd.tag;
        objd.transform.parent = parent.transform;
    }
}
