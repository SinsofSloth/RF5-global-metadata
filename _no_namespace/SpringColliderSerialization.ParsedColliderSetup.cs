public class SpringColliderSerialization.ParsedColliderSetup // TypeDefIndex: 9150
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x196040 Offset: 0x196141 VA: 0x196040
	private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x10
	private IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords; // 0x18
	private IEnumerable<SpringColliderSerialization.TransformSerializer> dynamicsNullRecords; // 0x20
	private List<TextRecordParsing.Record> componentRecords; // 0x28

	// Properties
	public IEnumerable<DynamicsSetup.ParseMessage> Errors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B4FB0 Offset: 0x1B50B1 VA: 0x1B4FB0
	// RVA: 0x239FB00 Offset: 0x239FC01 VA: 0x239FB00
	public IEnumerable<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4FC0 Offset: 0x1B50C1 VA: 0x1B4FC0
	// RVA: 0x239FB10 Offset: 0x239FC11 VA: 0x239FB10
	public void set_Errors(IEnumerable<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x239FB20 Offset: 0x239FC21 VA: 0x239FB20
	public static SpringColliderSerialization.ParsedColliderSetup ReadColliderSetupFromText(GameObject colliderRoot, string recordText) { }

	// RVA: 0x23A04E0 Offset: 0x23A05E1 VA: 0x23A04E0
	public void BuildObjects(GameObject colliderRoot) { }

	// RVA: 0x23A0B70 Offset: 0x23A0C71 VA: 0x23A0B70
	public IEnumerable<string> GetColliderNames() { }

	// RVA: 0x23A04D0 Offset: 0x23A05D1 VA: 0x23A04D0
	public void .ctor() { }
}

