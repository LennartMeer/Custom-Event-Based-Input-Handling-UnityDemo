using System;
using System.Threading.Tasks;
using Input;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        #region Fields & UI Color

        [SerializeField] private GameObject left, right, up, down, center;
        [SerializeField] private Color accentColor;
        
        private Color _originalColor;

        private void Awake()
        {
            _originalColor = center.GetComponent<Image>().color;
        }
        
        #endregion
        
        //Subscribing to Input Events of "InputEventSystem" Script on script enable
        private void Start()
        {
            InputEventSystem.Instance.NavigationInput += HandleNavigationInput;
            InputEventSystem.Instance.PressInput += HandlePressInput;
        }
        
        //Unsubscribing from Input Events of "InputEventSystem" Script on script destruction
        private void OnDestroy()
        {
            InputEventSystem.Instance.NavigationInput -= HandleNavigationInput;
            InputEventSystem.Instance.PressInput -= HandlePressInput;
        }

        #region UI Methods
        
        private void HandlePressInput()
        {
            ChangeColor(center);
        }

        private void HandleNavigationInput(Vector2 dir)
        {
            if (dir == Vector2.left) ChangeColor(left);
            if (dir == Vector2.right) ChangeColor(right);
            if (dir == Vector2.up) ChangeColor(up);
            if (dir == Vector2.down) ChangeColor(down);
        }

        private async void ChangeColor(GameObject uiElement)
        {
            var objectImage = uiElement.GetComponent<Image>();
            objectImage.color = accentColor;
            await Task.Delay(200);
            objectImage.color = _originalColor;
        }
        
        #endregion
    }
}
