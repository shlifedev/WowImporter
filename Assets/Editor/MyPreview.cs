using UnityEngine;
using UnityEditor;
using Asset = UnityEditor.AssetDatabase;
/**
 *  메뉴에서 와우 오브젝트 클릭 ->
 *  extractor에 오브젝트 정보 요청
 *  오브젝트 정보 받아서 파싱
 *  데이터 할당
 *  
 *  데이터 할당시 에디터 객체 생성
 */

public static class GameObjectEditorGUI
{  
    public static System.Action CreateGUI()
    {
        GameObject gameObject = null;
        Editor gameObjectEditor = null;
        Texture2D previewBackgroundTexture = null;
         
        return () =>
        { 
            EditorGUI.BeginChangeCheck();
            gameObject = (GameObject)EditorGUILayout.ObjectField(gameObject, typeof(GameObject), true);
            if (EditorGUI.EndChangeCheck())
            {
                if (gameObjectEditor != null)
                    UnityEditor.Editor.DestroyImmediate(gameObjectEditor);
            }

            GUIStyle bgColor = new GUIStyle();
            bgColor.normal.background = previewBackgroundTexture;

            if (gameObject != null)
            {
                if (gameObjectEditor == null)

                    gameObjectEditor = Editor.CreateEditor(gameObject);
                gameObjectEditor.OnInteractivePreviewGUI(GUILayoutUtility.GetRect(200, 200), bgColor);
            }
        };
    } 
 
} 
 
public class MyPreview : EditorWindow
{
    static System.Action DrawPreview = null;
    [MenuItem("Window/My Window")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MyPreview));
        if (DrawPreview == null)
            DrawPreview = GameObjectEditorGUI.CreateGUI();
    } 
    void OnGUI()
    {

        if (DrawPreview != null)
            DrawPreview();

    }
}
