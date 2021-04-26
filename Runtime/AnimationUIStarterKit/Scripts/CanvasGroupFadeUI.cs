using UnityEngine;

namespace AnimationUIStarterKit {
    public class CanvasGroupFadeUI : FadeUI {
        public CanvasGroup CanvasGroup;
        public override float CurrentAlpha { get => CanvasGroup.alpha; set => CanvasGroup.alpha = value; }
    }
}
