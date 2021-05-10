using Imp.solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public static Vector3 Vector3dToVector3(Vector3d vector3d)
    {
        return new Vector3(vector3d.x, vector3d.y, vector3d.z);
    }

    public static Vector3d Vector3ToVector3d(Vector3 vector3)
    {
        Vector3d vector3d = new Vector3d()
        {
            x = vector3.x,
            y = vector3.y,
            z = vector3.z
        };
        return vector3d;
    }
}
