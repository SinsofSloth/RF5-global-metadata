public class TaskUtility // TypeDefIndex: 4699
{
	// Fields
	public static char[] TrimCharacters; // 0x0
	private static Dictionary<string, Type> typeLookup; // 0x8
	private static List<Assembly> loadedAssemblies; // 0x10
	private static Dictionary<Type, FieldInfo[]> allFieldsLookup; // 0x18
	private static Dictionary<Type, FieldInfo[]> serializableFieldsLookup; // 0x20
	private static Dictionary<Type, FieldInfo[]> publicFieldsLookup; // 0x28
	private static Dictionary<FieldInfo, Dictionary<Type, bool>> hasFieldLookup; // 0x30

	// Methods

	// RVA: 0x1B22B00 Offset: 0x1B22C01 VA: 0x1B22B00
	private static void .cctor() { }

	// RVA: 0x1B22CA0 Offset: 0x1B22DA1 VA: 0x1B22CA0
	public static object CreateInstance(Type t) { }

	// RVA: 0x1B22D80 Offset: 0x1B22E81 VA: 0x1B22D80
	public static FieldInfo[] GetPublicFields(Type t) { }

	// RVA: 0x1B23110 Offset: 0x1B23211 VA: 0x1B23110
	public static FieldInfo[] GetSerializableFields(Type t) { }

	// RVA: 0x1B23280 Offset: 0x1B23381 VA: 0x1B23280
	private static void GetSerializableFields(Type t, IList<FieldInfo> fieldList, int flags) { }

	// RVA: 0x1B22EF0 Offset: 0x1B22FF1 VA: 0x1B22EF0
	private static void GetFields(Type t, ref List<FieldInfo> fieldList, int flags) { }

	// RVA: 0x1B237F0 Offset: 0x1B238F1 VA: 0x1B237F0
	public static Type GetTypeWithinAssembly(string typeName) { }

	// RVA: 0x1B23650 Offset: 0x1B23751 VA: 0x1B23650
	public static bool HasAttribute(FieldInfo field, Type attribute) { }
}

