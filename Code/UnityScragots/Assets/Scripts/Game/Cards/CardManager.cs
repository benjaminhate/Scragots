using System;
using ScriptableObjects.Cards;
using TMPro;
using UnityEngine;

namespace Game.Cards
{
    public class CardManager : MonoBehaviour
    {
        [Header("Scriptable Card")]
        public Card scriptableCard;

        [Header("UI Texts")]
        public TMP_Text cardNameText;
        public TMP_Text cardPowerText;
        public TMP_Text cardResistanceText;
        public TMP_Text cardTypeText;

        public void Start()
        {
            ApplyScriptableValues();
        }

        public void ApplyScriptableValues()
        {
            if (scriptableCard == null) return;
            cardNameText.text = scriptableCard.cardName;
            cardPowerText.text = scriptableCard.power.ToString();
            cardResistanceText.text = scriptableCard.resistance.ToString();
            cardTypeText.text = $"{scriptableCard.type} {(scriptableCard.rarity == CardRarity.Normal ? string.Empty : scriptableCard.rarity.ToString())}";
        }
    }
}