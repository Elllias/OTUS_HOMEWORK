using System;
using Game.Localization;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Meta
{
    [Serializable]
    public sealed class UpgradeMetadata
    {
        [TranslationKey]
        [SerializeField]
        public string localizedTitle;
        
        [PreviewField]
        [SerializeField]
        public Sprite icon;
    }
}