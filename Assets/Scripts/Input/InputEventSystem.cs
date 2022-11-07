using System;
using UnityEngine;

namespace Input
{
    public class InputEventSystem : MonoBehaviour
    {
        #region Singleton Pattern

        //Singleton Pattern
        public static InputEventSystem Instance { get; private set; }
        private void Awake() 
        { 
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else 
            { 
                Instance = this; 
            } 
        }

        #endregion

        public event Action<Vector2> NavigationInput;
        public void OnNavigationInput(Vector2 direction)
        {
            Debug.Log("Navigation Input Event Invoked - with: " + direction);
            
            //Checking if the NavigationInput Event exists - if true Invoke Event 
            NavigationInput?.Invoke(direction);
        }

        public event Action PressInput;
        public void OnPressInput()
        {
            Debug.Log("Press Input Event Invoked");
            
            //Checking if the PressInput Event exists - if true Invoke Event 
            PressInput?.Invoke();
        }
    }
}
