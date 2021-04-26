using UnityEngine.EventSystems;

namespace AnimationUIStarterKit {
    public class PointerFadeHoverUI : FadeHoverUI, IPointerEnterHandler, IPointerExitHandler {

        public void OnPointerEnter(PointerEventData eventData) {
            FadeIn();
        }

        public void OnPointerExit(PointerEventData eventData) {
            FadeOut();
        }

    }
}
