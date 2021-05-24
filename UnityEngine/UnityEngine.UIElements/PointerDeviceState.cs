internal static class PointerDeviceState // TypeDefIndex: 4208
{
	// Fields
	private static Vector2[] m_Positions; // 0x0
	private static IPanel[] m_Panels; // 0x8
	private static int[] m_PressedButtons; // 0x10

	// Methods

	// RVA: 0x15C6C90 Offset: 0x15C6D91 VA: 0x15C6C90
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel) { }

	// RVA: 0x15BA150 Offset: 0x15BA251 VA: 0x15BA150
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0x15B9CE0 Offset: 0x15B9DE1 VA: 0x15B9CE0
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0x15C3C30 Offset: 0x15C3D31 VA: 0x15C3C30
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0x15BAAE0 Offset: 0x15BABE1 VA: 0x15BAAE0
	public static Vector2 GetPointerPosition(int pointerId) { }

	// RVA: 0x15C6D90 Offset: 0x15C6E91 VA: 0x15C6D90
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0x15C6E30 Offset: 0x15C6F31 VA: 0x15C6E30
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0x15C6EE0 Offset: 0x15C6FE1 VA: 0x15C6EE0
	private static void .cctor() { }
}

