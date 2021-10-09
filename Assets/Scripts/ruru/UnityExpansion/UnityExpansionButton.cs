using UnityEngine.UI;
using UnityEngine.Events;

public static class UnityExpantionButton
{
    public static void SetListener(this Button.ButtonClickedEvent self, UnityAction call)
    {
        self.RemoveAllListeners();
        self.AddListener(call);
    }

}