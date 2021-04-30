using Imp.solution;
using SFB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    private string saveFirstPath;
    public void SaveScene()
    {
        if (string.IsNullOrEmpty(saveFirstPath))
        {
            saveFirstPath = StandaloneFileBrowser.SaveFilePanel("",Application.streamingAssetsPath,"MyProject","imp");

            if (!string .IsNullOrEmpty(saveFirstPath))
            {
                IO.Save(saveFirstPath,new SolutionInfo());
            }
        }
    }
}
