using UnityEditor;

namespace Game.Cards.Editor
{
    [CustomEditor(typeof(CardManager))]
    public class CardManagerEditor : UnityEditor.Editor
    {
        private void OnSceneGUI()
        {
            var cardManager = (CardManager) target;
            cardManager.ApplyScriptableValues();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            var cardManager = (CardManager) target;
            cardManager.ApplyScriptableValues();
        }
    }
}