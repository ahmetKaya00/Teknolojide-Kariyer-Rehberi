using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mermi : MonoBehaviour
{
    public static int _cephane, _yCephane;
    public int icCephane, yicCephane = 0;
    [SerializeField] GameObject Cephane, YCephane;

    private void Update()
    {
        icCephane = _cephane;
        Cephane.GetComponent<Text>().text = "" + icCephane;
        yicCephane = _yCephane;
        YCephane.GetComponent<Text>().text = "" + yicCephane;

    }
}
