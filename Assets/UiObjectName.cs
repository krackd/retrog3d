using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiObjectName : MonoBehaviour
{

    public TMPro.TextMeshProUGUI Label;

    public string ObjectName {
        set {
            Label.text = value;
        }

        get {
            return Label.text;
        }
    }

}
