using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

// Makes the task board fill any window size instead of a fixed 2048x1080 block
// centered on a 100x100 container (which cut off the left edge on 16:9 screens).
// Already applied to SampleScene.unity; kept as documentation of the change and
// in case the scene layout is reset.
public static class FixUIScaling
{
    const float OldMainSize = 100f;

    [MenuItem("Build/Fix UI scaling in SampleScene")]
    public static void Apply()
    {
        var scene = EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity");
        Canvas root = null;
        foreach (var c in Object.FindObjectsOfType<Canvas>(true))
            if (c.isRootCanvas) root = c;

        var scaler = root.GetComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        EditorUtility.SetDirty(scaler);

        var main = (RectTransform)root.transform.Find("Login/GamePanel/Main");
        if (main.anchorMin == Vector2.zero && main.anchorMax == Vector2.one)
        {
            Debug.Log("FIX: layout already applied");
        }
        else
        {
            // Popups keep their previous on-screen size, now centered independently of Main.
            FixedCentered((RectTransform)main.Find("Current Task"));
            FixedCentered((RectTransform)main.Find("Panel"));

            Stretch(main, 0f);
            Stretch((RectTransform)main.Find("Recyclable Scroll View"), 10f);
            Debug.Log("FIX: Main + board stretched to full window, popups centered");
        }

        if (root.worldCamera != null)
        {
            root.worldCamera.backgroundColor = new Color32(0xBF, 0xBF, 0xBF, 0xFF);
            EditorUtility.SetDirty(root.worldCamera);
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("FIX: scene saved");
        if (Application.isBatchMode)
            EditorApplication.Exit(0);
    }

    static void Stretch(RectTransform rt, float margin)
    {
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.offsetMin = new Vector2(margin, margin);
        rt.offsetMax = new Vector2(-margin, -margin);
        EditorUtility.SetDirty(rt);
    }

    static void FixedCentered(RectTransform rt)
    {
        var size = new Vector2(OldMainSize, OldMainSize) + rt.sizeDelta;
        var pos = rt.anchoredPosition;
        rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.sizeDelta = size;
        rt.anchoredPosition = pos;
        EditorUtility.SetDirty(rt);
    }
}
