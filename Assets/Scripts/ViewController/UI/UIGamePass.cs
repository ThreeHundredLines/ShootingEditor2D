using System;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace ShootingEditor2D
{
    public class UIGamePass : MonoBehaviour
    {
        private readonly Lazy<GUIStyle> mLabelStyle = new Lazy<GUIStyle>(() => new GUIStyle(GUI.skin.label)
        {
            fontSize = 150,
            alignment = TextAnchor.MiddleCenter,
        });
        private readonly Lazy<GUIStyle> mButtonStyle = new Lazy<GUIStyle>(() => new GUIStyle(GUI.skin.button)
        {
            fontSize = 40,
            alignment = TextAnchor.MiddleCenter,
        });
        private const float oneHalf = 0.5f;
        private void OnGUI()
        {
            var labelWidth = 1000;
            var labelHeight = 200;
            var labelPos = new Vector2(Screen.width - labelWidth, Screen.height - labelHeight) * oneHalf;
            var labelSize = new Vector2(labelWidth, labelHeight);
            var labelRect = new Rect(labelPos, labelSize);
            GUI.Label(labelRect, "游戏通关", mLabelStyle.Value);
            var buttonWidth = 300;
            var buttonHeight = 100;
            var buttonPos = new Vector2(Screen.width, Screen.height) * oneHalf - new Vector2(buttonWidth * oneHalf, buttonHeight * oneHalf) + new Vector2(0, 150);
            var buttonSize = new Vector2(buttonWidth, buttonHeight);
            var buttonRect = new Rect(buttonPos, buttonSize);
            if (GUI.Button(buttonRect, "回到首页", mButtonStyle.Value)) SceneManager.LoadScene("GameStart");
        }
    }
}