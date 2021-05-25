public class DynamicsSetup // TypeDefIndex: 9123
{
	// Fields
	private const int UnknownVersion = -1;
	private DynamicsSetup.ImportSettings importSettings; // 0x10
	private GameObject springBoneRoot; // 0x18
	private GameObject colliderRoot; // 0x20
	private SpringBoneSerialization.ParsedSpringBoneSetup springBoneSetup; // 0x28
	private SpringColliderSerialization.ParsedColliderSetup colliderSetup; // 0x30

	// Methods

	// RVA: 0x1FFC1D0 Offset: 0x1FFC2D1 VA: 0x1FFC1D0
	public static bool BuildFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings, IEnumerable<string> requiredBones) { }

	// RVA: 0x1FFC260 Offset: 0x1FFC361 VA: 0x1FFC260
	public static DynamicsSetup.ParseResults ParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings) { }

	// RVA: 0x1FFC3C0 Offset: 0x1FFC4C1 VA: 0x1FFC3C0
	public void Build(IEnumerable<string> requiredBones) { }

	// RVA: 0x1FFCFD0 Offset: 0x1FFD0D1 VA: 0x1FFCFD0
	public static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords, out TextRecordParsing.Record versionRecord) { }

	// RVA: 0x1FFD120 Offset: 0x1FFD221 VA: 0x1FFD120
	public static object SerializeObjectFromStrings(Type type, IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error) { }

	// RVA: -1 Offset: -1
	public static T SerializeObjectFromStrings<T>(IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22652A0 Offset: 0x22653A1 VA: 0x22652A0
	|-DynamicsSetup.SerializeObjectFromStrings<object>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringBoneSerialization.PivotSerializer>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringColliderSerialization.ColliderSerializerBaseInfo>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringColliderSerialization.TransformSerializer>
	*/

	// RVA: 0x1FFD3C0 Offset: 0x1FFD4C1 VA: 0x1FFD3C0
	private static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords) { }

	// RVA: 0x1FFD3F0 Offset: 0x1FFD4F1 VA: 0x1FFD3F0
	private static bool VerifyVersionAndDetectContents(string recordText, DynamicsSetup.ImportSettings importSettings, out string errorMessage) { }

	// RVA: 0x1FFC440 Offset: 0x1FFC541 VA: 0x1FFC440
	private static DynamicsSetup.ParseResults InternalParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings) { }

	// RVA: 0x1FFE180 Offset: 0x1FFE281 VA: 0x1FFE180
	public void .ctor() { }
}

