using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject left, right, up, down, center;
        [SerializeField] private Color accentColor;
        
        private Color _originalColor;
        private Color _colorLeft, _colorRight, _colorUp, _colorDown, _colorCenter;

        private void Awake()
        {
            _originalColor = center.GetComponent<Image>().color;
        }

        public async void InputLeft()
        {
            _colorLeft = accentColor;
            await Task.Delay(200);
            _colorLeft = _originalColor;
        }

        public async void InputRight()
        {
            _colorRight = accentColor;
            await Task.Delay(200);
            _colorRight = _originalColor;
        }

        public async void InputUp()
        {
            _colorUp = accentColor;
            await Task.Delay(200);
            _colorUp = _originalColor;
        }

        public async void InputDown()
        {
            _colorDown = accentColor;
            await Task.Delay(200);
            _colorDown = _originalColor;
        }

        public async void InputCenter()
        {
            _colorCenter = accentColor;
            await Task.Delay(200);
            _colorCenter = _originalColor;
        }

    }
}
