using UnityEngine;
using System.Collections;

public class FallInChecker : MonoBehaviour {

    public GUISkin gsk;

    public Hole red;
    public Hole blue;
    public Hole green;
    
    void OnGUI()
    {
        string label = " ";
        if(red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
        {
            label = "All ball is Fall in hole!";
        }
        GUILayout.BeginArea(new Rect(0,0,500,48));
        GUILayout.Label(label, gsk.label);
        GUILayout.EndArea();
    } 
}
