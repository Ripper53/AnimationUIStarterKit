using UnityEngine;
using UnityEngine.EventSystems;

namespace AnimationUIStarterKit {
    public class HoverUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
        public GameObject UI;

        public virtual void OnPointerEnter(PointerEventData eventData) {
            UI.SetActive(true);
        }

        public virtual void OnPointerExit(PointerEventData eventData) {
            UI.SetActive(false);
        }

    }
}
