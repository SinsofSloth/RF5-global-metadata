internal class AttributeHelperEngine // TypeDefIndex: 2991
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CB0 Offset: 0xD5DB1 VA: 0xD5CB0
	// RVA: 0x2AF7C10 Offset: 0x2AF7D11 VA: 0x2AF7C10
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CC0 Offset: 0xD5DC1 VA: 0xD5CC0
	// RVA: 0x2AF7D10 Offset: 0x2AF7E11 VA: 0x2AF7D10
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x2AF8050 Offset: 0x2AF8151 VA: 0x2AF8050
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CD0 Offset: 0xD5DD1 VA: 0xD5CD0
	// RVA: 0x2AF8170 Offset: 0x2AF8271 VA: 0x2AF8170
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CE0 Offset: 0xD5DE1 VA: 0xD5CE0
	// RVA: 0x2AF8260 Offset: 0x2AF8361 VA: 0x2AF8260
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22658A0 Offset: 0x22659A1 VA: 0x22658A0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	// RVA: 0x2AF82F0 Offset: 0x2AF83F1 VA: 0x2AF82F0
	private static void .cctor() { }
}

