using UnityEngine;

public static class ColorUtils
{
    public static void SetAlpha(this tk2dSprite self, float newAlpha)
    {
        self.color = new Color(self.color.r, self.color.g, self.color.b, newAlpha);
    }
    public static void SetAlpha(this TMPro.TMP_Text self, float newAlpha)
    {
        self.color = new Color(self.color.r, self.color.g, self.color.b, newAlpha);
    }
}