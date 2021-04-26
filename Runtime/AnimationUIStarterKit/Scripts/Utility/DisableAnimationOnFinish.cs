using UnityEngine;
using AnimationUIStarterKit;

namespace AnimationUIStarterKit.Utility {
    public class DisableAnimationOnFinish : MonoBehaviour {
        public AnimationUI AnimationUI;

        private void LateUpdate() {
            if (!AnimationUI.IsFinished) return;
            AnimationUI.End();
            AnimationUI.enabled = false;
            enabled = false;
        }

    }
}
