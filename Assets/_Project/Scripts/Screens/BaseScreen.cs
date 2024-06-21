using _Project.Services;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

namespace _Project.Screens
{
    public abstract class BaseScreen : MonoBehaviour
    {
        protected virtual void ButtonOnClicked(Button button, TweenCallback callback)
        {
            AudioService.Instance.PlaySound("Click");
            AnimationService.Instance.PlayAnimation(button.gameObject, callback);
        }
    }
}
