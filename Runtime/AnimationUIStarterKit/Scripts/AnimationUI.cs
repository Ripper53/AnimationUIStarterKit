using UnityEngine;

namespace AnimationUIStarterKit {
    public abstract class AnimationUI : MonoBehaviour {
        public abstract bool IsFinished { get; }
        public abstract void End();
    }
}
