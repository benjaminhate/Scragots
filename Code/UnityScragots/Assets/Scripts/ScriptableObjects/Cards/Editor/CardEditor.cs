using UnityEditor;
using UnityEngine;

namespace ScriptableObjects.Cards.Editor
{
    [CustomEditor(typeof(Card))]
    public class CardEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var card = (Card) target;
        }
    }
}