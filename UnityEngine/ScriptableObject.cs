[RequiredByNativeCodeAttribute] // RVA: 0xC6D00 Offset: 0xC6E01 VA: 0xC6D00
[ExtensionOfNativeClassAttribute] // RVA: 0xC6D00 Offset: 0xC6E01 VA: 0xC6D00
[NativeHeaderAttribute] // RVA: 0xC6D00 Offset: 0xC6E01 VA: 0xC6D00
[NativeClassAttribute] // RVA: 0xC6D00 Offset: 0xC6E01 VA: 0xC6D00
public class ScriptableObject : Object // TypeDefIndex: 3022
{
	// Methods

	// RVA: 0x2A20B90 Offset: 0x2A20C91 VA: 0x2A20B90
	public void .ctor() { }

	// RVA: 0x2A26A90 Offset: 0x2A26B91 VA: 0x2A26A90
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266ED0 Offset: 0x2266FD1 VA: 0x2266ED0
	|-ScriptableObject.CreateInstance<NpcShopTable>
	|-ScriptableObject.CreateInstance<Settings>
	|-ScriptableObject.CreateInstance<TMP_FontAsset>
	|-ScriptableObject.CreateInstance<MarkerTrack>
	|-ScriptableObject.CreateInstance<object>
	|-ScriptableObject.CreateInstance<PlayerConnection>
	*/

	[NativeMethodAttribute] // RVA: 0xD6E40 Offset: 0xD6F41 VA: 0xD6E40
	// RVA: 0x2A26A40 Offset: 0x2A26B41 VA: 0x2A26A40
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xD6E80 Offset: 0xD6F81 VA: 0xD6E80
	// RVA: 0x2A26AE0 Offset: 0x2A26BE1 VA: 0x2A26AE0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }
}

