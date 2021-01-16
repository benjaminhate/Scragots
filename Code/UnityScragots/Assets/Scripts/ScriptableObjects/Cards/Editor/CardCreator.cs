using UnityEditor;
using UnityEngine;

namespace ScriptableObjects.Cards.Editor
{
    public class CardCreator : EditorWindow
    {
        private const string Title = "Card Creator";
        
        [MenuItem("Tools/Scragots/CardCreator")]
        public static void OpenWindow()
        {
            GetWindow<CardCreator>(Title);
        }

        private void OnGUI()
        {
            DrawHeader();
            
            GUILayout.Space(10f);

            DrawCreator();
        }

        private void DrawHeader()
        {
            GUILayout.Label(Title, EditorStyles.boldLabel);
        }

        private void DrawCreator()
        {
            
        }
    }
}