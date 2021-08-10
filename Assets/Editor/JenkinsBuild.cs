using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;

public class JenkinsBuild 
{
    [MenuItem("Custom Utilities/Build StandaloneWindows64")]
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.exe",
            BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    [MenuItem("Custom Utilities/Build Asset Bundle StandaloneWindows64")]
    static void PerformAssetBundleBuild()
    {
        BuildPipeline.BuildAssetBundles("../AssetBundles/", BuildAssetBundleOptions.ChunkBasedCompression,
            BuildTarget.StandaloneWindows64);
    }
}
