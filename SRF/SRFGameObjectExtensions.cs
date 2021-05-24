[ExtensionAttribute] // RVA: 0x126DB0 Offset: 0x126EB1 VA: 0x126DB0
public static class SRFGameObjectExtensions // TypeDefIndex: 4306
{
	// Methods

	[ExtensionAttribute] // RVA: 0x127FA0 Offset: 0x1280A1 VA: 0x127FA0
	// RVA: -1 Offset: -1
	public static T GetIComponent<T>(GameObject t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C6920 Offset: 0x23C6A21 VA: 0x23C6920
	|-SRFGameObjectExtensions.GetIComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x127FB0 Offset: 0x1280B1 VA: 0x127FB0
	// RVA: -1 Offset: -1
	public static T GetComponentOrAdd<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C6850 Offset: 0x23C6951 VA: 0x23C6850
	|-SRFGameObjectExtensions.GetComponentOrAdd<RectTransform>
	|-SRFGameObjectExtensions.GetComponentOrAdd<StyleRoot>
	|-SRFGameObjectExtensions.GetComponentOrAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x127FC0 Offset: 0x1280C1 VA: 0x127FC0
	// RVA: -1 Offset: -1
	public static void RemoveComponentIfExists<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6C50 Offset: 0x21D6D51 VA: 0x21D6C50
	|-SRFGameObjectExtensions.RemoveComponentIfExists<SRRetinaScaler>
	|-SRFGameObjectExtensions.RemoveComponentIfExists<object>
	|-SRFGameObjectExtensions.RemoveComponentIfExists<CanvasScaler>
	*/

	[ExtensionAttribute] // RVA: 0x127FD0 Offset: 0x1280D1 VA: 0x127FD0
	// RVA: -1 Offset: -1
	public static void RemoveComponentsIfExists<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6D20 Offset: 0x21D6E21 VA: 0x21D6D20
	|-SRFGameObjectExtensions.RemoveComponentsIfExists<object>
	*/

	[ExtensionAttribute] // RVA: 0x127FE0 Offset: 0x1280E1 VA: 0x127FE0
	// RVA: -1 Offset: -1
	public static bool EnableComponentIfExists<T>(GameObject obj, bool enable = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519C60 Offset: 0x2519D61 VA: 0x2519C60
	|-SRFGameObjectExtensions.EnableComponentIfExists<object>
	*/

	[ExtensionAttribute] // RVA: 0x127FF0 Offset: 0x1280F1 VA: 0x127FF0
	// RVA: 0x1A80560 Offset: 0x1A80661 VA: 0x1A80560
	public static void SetLayerRecursive(GameObject o, int layer) { }

	// RVA: 0x1A80590 Offset: 0x1A80691 VA: 0x1A80590
	private static void SetLayerInternal(Transform t, int layer) { }
}

