using UnityEngine;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        void Update()
        {
            //Calling "GetInput" Variables every frame and casting return to var
            var navigationInput = GetNavigationInput();
            var pressInput = GetPressInput();

            //Calling Event functions of InputEventSystem - when Values match if conditions
            if (navigationInput != Vector2.zero) InputEventSystem.Instance.OnNavigationInput(navigationInput);
            if (pressInput) InputEventSystem.Instance.OnPressInput();
        }

        private Vector2 GetNavigationInput()
        {
            //This Method can be filled with custom Input Behavior - as long as a Vector2 (input direction) is returned
            
            if (UnityEngine.Input.GetKeyDown(KeyCode.LeftArrow)) return Vector2.left;
            if (UnityEngine.Input.GetKeyDown(KeyCode.RightArrow)) return Vector2.right;
            if (UnityEngine.Input.GetKeyDown(KeyCode.UpArrow)) return Vector2.up;
            if (UnityEngine.Input.GetKeyDown(KeyCode.DownArrow)) return Vector2.down;
        
            return Vector2.zero;
        }

        private bool GetPressInput()
        {
            //This Method can be filled with custom Input Behavior - as long as a bool (press state) is returned
            
            return UnityEngine.Input.GetKeyDown(KeyCode.Return);
        }
    }
}
