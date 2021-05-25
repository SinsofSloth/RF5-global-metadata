[NativeHeaderAttribute] // RVA: 0xC6580 Offset: 0xC6681 VA: 0xC6580
[NativeHeaderAttribute] // RVA: 0xC6580 Offset: 0xC6681 VA: 0xC6580
public sealed class Resources // TypeDefIndex: 2989
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7B60 Offset: 0x34F7C61 VA: 0x34F7B60
	|-Resources.ConvertObjects<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xD5930 Offset: 0xD5A31 VA: 0xD5930
	[FreeFunctionAttribute] // RVA: 0xD5930 Offset: 0xD5A31 VA: 0xD5930
	// RVA: 0x2A24150 Offset: 0x2A24251 VA: 0x2A24150
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x2A241A0 Offset: 0x2A242A1 VA: 0x2A241A0
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266DF0 Offset: 0x2266EF1 VA: 0x2266DF0
	|-Resources.Load<RuneAbilityDataTableArray>
	|-Resources.Load<Settings>
	|-Resources.Load<PinEntryControl>
	|-Resources.Load<DebugPanelRoot>
	|-Resources.Load<BugReportPopoverRoot>
	|-Resources.Load<BugReportSheetController>
	|-Resources.Load<PinnedUIRoot>
	|-Resources.Load<TriggerRoot>
	|-Resources.Load<TMP_ColorGradient>
	|-Resources.Load<TMP_FontAsset>
	|-Resources.Load<TMP_Settings>
	|-Resources.Load<TMP_SpriteAsset>
	|-Resources.Load<AudioMixer>
	|-Resources.Load<GameObject>
	|-Resources.Load<Material>
	|-Resources.Load<Shader>
	|-Resources.Load<Sprite>
	|-Resources.Load<TextAsset>
	|-Resources.Load<object>
	*/

	[NativeThrowsAttribute] // RVA: 0xD5980 Offset: 0xD5A81 VA: 0xD5980
	[FreeFunctionAttribute] // RVA: 0xD5980 Offset: 0xD5A81 VA: 0xD5980
	[TypeInferenceRuleAttribute] // RVA: 0xD5980 Offset: 0xD5A81 VA: 0xD5980
	// RVA: 0x2A240F0 Offset: 0x2A241F1 VA: 0x2A240F0
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static ResourceRequest LoadAsync<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FE090 Offset: 0x34FE191 VA: 0x34FE090
	|-Resources.LoadAsync<object>
	*/

	// RVA: 0x2A24250 Offset: 0x2A24351 VA: 0x2A24250
	public static ResourceRequest LoadAsync(string path, Type type) { }

	[FreeFunctionAttribute] // RVA: 0xD59E0 Offset: 0xD5AE1 VA: 0xD59E0
	// RVA: 0x2A242D0 Offset: 0x2A243D1 VA: 0x2A242D0
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xD5A20 Offset: 0xD5B21 VA: 0xD5A20
	[FreeFunctionAttribute] // RVA: 0xD5A20 Offset: 0xD5B21 VA: 0xD5A20
	// RVA: 0x2A24320 Offset: 0x2A24421 VA: 0x2A24320
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7C90 Offset: 0x34F7D91 VA: 0x34F7C90
	|-Resources.LoadAll<ActionControl>
	|-Resources.LoadAll<DataBoundControl>
	|-Resources.LoadAll<SRTab>
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xD5A70 Offset: 0xD5B71 VA: 0xD5A70
	[FreeFunctionAttribute] // RVA: 0xD5A70 Offset: 0xD5B71 VA: 0xD5A70
	// RVA: 0x2A24370 Offset: 0x2A24471 VA: 0x2A24370
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266D10 Offset: 0x2266E11 VA: 0x2266D10
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xD5AC0 Offset: 0xD5BC1 VA: 0xD5AC0
	// RVA: 0x2A243C0 Offset: 0x2A244C1 VA: 0x2A243C0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xD5B00 Offset: 0xD5C01 VA: 0xD5B00
	// RVA: 0x2A24410 Offset: 0x2A24511 VA: 0x2A24410
	public static AsyncOperation UnloadUnusedAssets() { }
}

