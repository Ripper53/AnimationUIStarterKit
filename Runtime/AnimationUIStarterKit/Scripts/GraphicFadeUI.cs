using UnityEngine;
using UnityEngine.UI;

namespace AnimationUIStarterKit {
    public class GraphicFadeUI : FadeUI {
        public Graphic Image;
        public override float CurrentAlpha {
            get => Image.color.a;
            set {
                Color color = Image.color;
                color.a = value;
                Image.color = color;
            }
        }
    }
}
