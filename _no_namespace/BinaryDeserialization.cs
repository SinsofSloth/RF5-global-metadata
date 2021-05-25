public static class BinaryDeserialization // TypeDefIndex: 4667
{
	// Fields
	private static GlobalVariables globalVariables; // 0x0
	private static Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>> taskIDs; // 0x8
	private static SHA1 shaHash; // 0x10
	private static bool updatedSerialization; // 0x18
	private static bool shaHashSerialization; // 0x19
	private static bool strHashSerialization; // 0x1A
	private static int animationCurveAdvance; // 0x1C
	private static bool enumSerialization; // 0x20
	private static byte[] sBigEndianFourByteArray; // 0x28
	private static byte[] sBigEndianEightByteArray; // 0x30

	// Properties
	private static byte[] BigEndianFourByteArray { get; }
	private static byte[] BigEndianEightByteArray { get; }

	// Methods

	// RVA: 0x1B25F50 Offset: 0x1B26051 VA: 0x1B25F50
	private static void .cctor() { }

	// RVA: 0x1B25FB0 Offset: 0x1B260B1 VA: 0x1B25FB0
	private static byte[] get_BigEndianFourByteArray() { }

	// RVA: 0x1B260A0 Offset: 0x1B261A1 VA: 0x1B260A0
	private static byte[] get_BigEndianEightByteArray() { }

	// RVA: 0x1B26190 Offset: 0x1B26291 VA: 0x1B26190
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x1B28CC0 Offset: 0x1B28DC1 VA: 0x1B28CC0
	public static void Load(GlobalVariables globalVariables, string version) { }

	// RVA: 0x1B27FD0 Offset: 0x1B280D1 VA: 0x1B27FD0
	public static void LoadTask(TaskSerializationData taskSerializationData, FieldSerializationData fieldSerializationData, ref List<Task> taskList, ref BehaviorSource behaviorSource) { }

	// RVA: 0x1B2B3A0 Offset: 0x1B2B4A1 VA: 0x1B2B3A0
	private static void LoadNodeData(FieldSerializationData fieldSerializationData, Dictionary<int, int> fieldIndexMap, Task task) { }

	// RVA: 0x1B2B9E0 Offset: 0x1B2BAE1 VA: 0x1B2B9E0
	private static void LoadFields(FieldSerializationData fieldSerializationData, Dictionary<int, int> fieldIndexMap, object obj, int hashPrefix, IVariableSource variableSource) { }

	// RVA: 0x1B292A0 Offset: 0x1B293A1 VA: 0x1B292A0
	private static object LoadField(FieldSerializationData fieldSerializationData, Dictionary<int, int> fieldIndexMap, Type fieldType, string fieldName, int hashPrefix, IVariableSource variableSource, object obj, FieldInfo fieldInfo) { }

	// RVA: 0x1B2BDD0 Offset: 0x1B2BED1 VA: 0x1B2BDD0
	public static int StringHash(string value, bool fastHash) { }

	// RVA: 0x1B2C0C0 Offset: 0x1B2C1C1 VA: 0x1B2C0C0
	private static int GetFieldSize(FieldSerializationData fieldSerializationData, int fieldIndex) { }

	// RVA: 0x1B2BFA0 Offset: 0x1B2C0A1 VA: 0x1B2BFA0
	private static int BytesToInt(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C350 Offset: 0x1B2C451 VA: 0x1B2C350
	private static uint BytesToUInt(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C470 Offset: 0x1B2C571 VA: 0x1B2C470
	private static float BytesToFloat(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C590 Offset: 0x1B2C691 VA: 0x1B2C590
	private static double BytesToDouble(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C6B0 Offset: 0x1B2C7B1 VA: 0x1B2C6B0
	private static long BytesToLong(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C7D0 Offset: 0x1B2C8D1 VA: 0x1B2C7D0
	private static bool BytesToBool(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C1A0 Offset: 0x1B2C2A1 VA: 0x1B2C1A0
	private static string BytesToString(byte[] bytes, int dataPosition, int dataSize) { }

	// RVA: 0x1B2C850 Offset: 0x1B2C951 VA: 0x1B2C850
	private static byte BytesToByte(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CE00 Offset: 0x1B2CF01 VA: 0x1B2CE00
	private static Color BytesToColor(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C890 Offset: 0x1B2C991 VA: 0x1B2C890
	private static Vector2 BytesToVector2(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C950 Offset: 0x1B2CA51 VA: 0x1B2C950
	private static Vector2Int BytesToVector2Int(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CA30 Offset: 0x1B2CB31 VA: 0x1B2CA30
	private static Vector3 BytesToVector3(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CB10 Offset: 0x1B2CC11 VA: 0x1B2CB10
	private static Vector3Int BytesToVector3Int(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CC20 Offset: 0x1B2CD21 VA: 0x1B2CC20
	private static Vector4 BytesToVector4(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CD10 Offset: 0x1B2CE11 VA: 0x1B2CD10
	private static Quaternion BytesToQuaternion(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CED0 Offset: 0x1B2CFD1 VA: 0x1B2CED0
	private static Rect BytesToRect(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2CFB0 Offset: 0x1B2D0B1 VA: 0x1B2CFB0
	private static Matrix4x4 BytesToMatrix4x4(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2D1D0 Offset: 0x1B2D2D1 VA: 0x1B2D1D0
	private static AnimationCurve BytesToAnimationCurve(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2D4A0 Offset: 0x1B2D5A1 VA: 0x1B2D4A0
	private static LayerMask BytesToLayerMask(byte[] bytes, int dataPosition) { }

	// RVA: 0x1B2C2A0 Offset: 0x1B2C3A1 VA: 0x1B2C2A0
	private static Object IndexToUnityObject(int index, FieldSerializationData activeFieldSerializationData) { }

	// RVA: 0x1B27530 Offset: 0x1B27631 VA: 0x1B27530
	private static SharedVariable BytesToSharedVariable(FieldSerializationData fieldSerializationData, Dictionary<int, int> fieldIndexMap, byte[] bytes, int dataPosition, IVariableSource variableSource, bool fromField, int hashPrefix) { }
}

