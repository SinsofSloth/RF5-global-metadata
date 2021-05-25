public class SpringBoneSerialization.ParsedSpringBoneSetup // TypeDefIndex: 9130
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x196030 Offset: 0x196131 VA: 0x196030
	private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x10
	private IEnumerable<SpringBoneSerialization.PivotSerializer> pivotRecords; // 0x18
	private IEnumerable<SpringBoneSerialization.SpringBoneSerializer> springBoneRecords; // 0x20

	// Properties
	public IEnumerable<DynamicsSetup.ParseMessage> Errors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B4F90 Offset: 0x1B5091 VA: 0x1B4F90
	// RVA: 0x2008DB0 Offset: 0x2008EB1 VA: 0x2008DB0
	public IEnumerable<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4FA0 Offset: 0x1B50A1 VA: 0x1B4FA0
	// RVA: 0x2008DC0 Offset: 0x2008EC1 VA: 0x2008DC0
	public void set_Errors(IEnumerable<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x1FFD9A0 Offset: 0x1FFDAA1 VA: 0x1FFD9A0
	public static SpringBoneSerialization.ParsedSpringBoneSetup ReadSpringBoneSetupFromText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, IEnumerable<string> inputValidColliderNames) { }

	// RVA: 0x1FFC9F0 Offset: 0x1FFCAF1 VA: 0x1FFC9F0
	public void BuildObjects(GameObject springBoneRoot, GameObject colliderRoot, IEnumerable<string> requiredBones) { }

	// RVA: 0x20090B0 Offset: 0x20091B1 VA: 0x20090B0
	private void FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones(GameObject springBoneRoot, IEnumerable<string> requiredBones) { }

	// RVA: 0x2008DF0 Offset: 0x2008EF1 VA: 0x2008DF0
	public void .ctor() { }
}

