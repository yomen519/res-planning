using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

// Builds a standalone Windows .exe of the demo scene into Build/ (ignored by git).
// Menu: Build > Windows demo (.exe)
// Batch: Unity.exe -batchmode -quit -projectPath <ZarzProj> -executeMethod BuildDemo.BuildWindows -logFile build.log
public static class BuildDemo
{
    const string Scene = "Assets/Scenes/SampleScene.unity";
    const string Output = "Build/ResearchPlanner.exe";

    [MenuItem("Build/Windows demo (.exe)")]
    public static void BuildWindows()
    {
        PlayerSettings.companyName = "WSAiP";
        PlayerSettings.productName = "Research Planner";
        PlayerSettings.fullScreenMode = FullScreenMode.MaximizedWindow;
        PlayerSettings.defaultScreenWidth = 1920;
        PlayerSettings.defaultScreenHeight = 1080;
        PlayerSettings.resizableWindow = true;

        var options = new BuildPlayerOptions
        {
            scenes = new[] { Scene },
            locationPathName = Output,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(options);
        var summary = report.summary;
        Debug.Log($"BUILD RESULT: {summary.result}, errors: {summary.totalErrors}, size: {summary.totalSize / (1024 * 1024)} MB, output: {summary.outputPath}");
        foreach (var msg in report.steps.SelectMany(s => s.messages).Where(m => m.type == LogType.Error || m.type == LogType.Exception))
            Debug.Log("BUILD ERROR: " + msg.content);

        if (Application.isBatchMode)
            EditorApplication.Exit(summary.result == BuildResult.Succeeded ? 0 : 1);
    }
}
