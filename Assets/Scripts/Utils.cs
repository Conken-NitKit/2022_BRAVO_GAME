using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// unityの便利メソッドまとめ
/// </summary>
public class Utils : MonoBehaviour
{
    /// <summary>
    /// Vector３のX軸の最大値をとってくるメソッド
    /// </summary>
    public static float GetWidest(Vector3[] vecs)
    {
        float currentWidest = Mathf.Infinity * -1;

        foreach (Vector3 vec in vecs)
        {
            currentWidest = Mathf.Max(currentWidest, vec.x);
        }

        return currentWidest;
    }

    /// <summary>
    /// Vector３のX軸の最大値の要素番号をとってくるメソッド
    /// </summary>
    public static int GetWidestNumber(Vector3[] vecs)
    {
        float currentWidest = Mathf.Infinity * -1;
        int currentWidestNumber = 0;

        for (int i = 0; i < vecs.Length; i++)
        {
            if (currentWidest < vecs[i].x)
            {
                currentWidest = vecs[i].x;
                currentWidestNumber = i;
            }
        }

        return currentWidestNumber;
    }

    /// <summary>
    /// Vector３のY軸の最大値をとってくるメソッド
    /// </summary>
    public static float GetHighest(Vector3[] vecs)
    {
        float currentHighest = Mathf.Infinity * -1;

        foreach (Vector3 vec in vecs)
        {
            currentHighest = Mathf.Max(currentHighest, vec.y);
        }

        return currentHighest;
    }

    /// <summary>
    /// Vector３のY軸の最大値の要素番号をとってくるメソッド
    /// </summary>
    public static int GetHighestNumber(Vector3[] vecs)
    {
        float currentHighest = Mathf.Infinity * -1;
        int currentHighestNumber = 0;

        for (int i = 0; i < vecs.Length; i++)
        {
            if (currentHighest < vecs[i].y)
            {
                currentHighest = vecs[i].y;
                currentHighestNumber = i;
            }
        }

        return currentHighestNumber;
    }

    /// <summary>
    /// Vector３のZ軸の最大値をとってくるメソッド
    /// </summary>
    public static float GetDeepest(Vector3[] vecs)
    {
        float currentDeepest = Mathf.Infinity * -1;

        foreach (Vector3 vec in vecs)
        {
            currentDeepest = Mathf.Max(currentDeepest, vec.y);
        }

        return currentDeepest;
    }

    /// <summary>
    /// Vector３のZ軸の最大値の要素番号をとってくるメソッド
    /// </summary>
    public static int GetDeepestNumber(Vector3[] vecs)
    {
        float currentDeepest = Mathf.Infinity * -1;
        int currentDeepestNumber = 0;

        for (int i = 0; i < vecs.Length; i++)
        {
            if (currentDeepest < vecs[i].z)
            {
                currentDeepest = vecs[i].z;
                currentDeepestNumber = i;
            }
        }

        return currentDeepestNumber;
    }

    /// <summary>
    /// 引数で指定されたタグの名前のオブジェクトを探して全削除するメソッド
    /// </summary>
    public static void DestroyGameObjectsWithTag(string tag)
    {
        foreach (GameObject found in GameObject.FindGameObjectsWithTag(tag))
        {
            Destroy(found);
        }
    }
}
