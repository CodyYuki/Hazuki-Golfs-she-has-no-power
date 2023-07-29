using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class ExtensionsUtility
{


    static public void SetWorldPosX(this Transform transform, float x)
    {
        transform.position = new Vector3(x,
                                         transform.position.y,
                                         transform.position.z);
    }

    static public void SetWorldPosY(this Transform transform, float y)
    {
        transform.position = new Vector3(transform.position.x,
                                         y,
                                         transform.position.z);
    }

    static public void SetWorldPosZ(this Transform transform, float z)
    {
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y,
                                         z);
    }

    static public void SetWorldPosXY(this Transform transform, float x, float y)
    {
        transform.position = new Vector3(x,
                                         y,
                                         transform.position.z);
    }

    static public void SetWorldPos(this Transform transform, float x, float y, float z)
    {
        transform.position = new Vector3(x,
                                         y,
                                         z);
    }
    static public void SetPosX(this Transform transform, float x)
    {
        transform.localPosition = new Vector3(x,
                                              transform.localPosition.y,
                                              transform.localPosition.z);
    }

    static public void SetPosY(this Transform transform, float y)
    {
        transform.localPosition = new Vector3(transform.localPosition.x,
                                              y,
                                              transform.localPosition.z);
    }

    static public void SetPosZ(this Transform transform, float z)
    {
        transform.localPosition = new Vector3(transform.localPosition.x,
                                              transform.localPosition.y,
                                              z);
    }

    static public void SetPosXY(this Transform transform, float x, float y)
    {
        transform.localPosition = new Vector3(x,
                                              y,
                                              transform.localPosition.z);
    }

    static public void SetPos(this Transform transform, float x, float y, float z)
    {
        transform.localPosition = new Vector3(x,
                                              y,
                                              z);
    }





}
