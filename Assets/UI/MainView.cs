namespace UI
{
    using UnityEngine;
    using UnityEngine.UIElements;

    public class MainView : MonoBehaviour
    {
        [SerializeField] VisualTreeAsset m_ListEntryTemplate;

        void OnEnable()
        {
            // The UXML is already instantiated by the UIDocument component
            var uiDocument = GetComponent<UIDocument>();

            // Initialize the character list controller
            var characterListController = new DebugController();
            characterListController.InitializeCharacterList(uiDocument.rootVisualElement, m_ListEntryTemplate);
        }
    }
}