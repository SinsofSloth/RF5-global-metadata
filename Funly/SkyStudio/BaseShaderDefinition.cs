[Serializable]
public abstract class BaseShaderDefinition : IProfileDefinition // TypeDefIndex: 9672
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17D7F0 Offset: 0x17D8F1 VA: 0x17D7F0
	private string <shaderName>k__BackingField; // 0x10
	private ProfileGroupSection[] m_ProfileDefinitions; // 0x18
	[SerializeField] // RVA: 0x17D800 Offset: 0x17D901 VA: 0x17D800
	private ProfileFeatureSection[] m_ProfileFeatures; // 0x20
	private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature; // 0x28

	// Properties
	public string shaderName { get; set; }
	public ProfileGroupSection[] groups { get; }
	public ProfileFeatureSection[] features { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC5F0 Offset: 0x1AC6F1 VA: 0x1AC5F0
	// RVA: 0x22AF0E0 Offset: 0x22AF1E1 VA: 0x22AF0E0 Slot: 4
	public string get_shaderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC600 Offset: 0x1AC701 VA: 0x1AC600
	// RVA: 0x22AF0F0 Offset: 0x22AF1F1 VA: 0x22AF0F0
	protected void set_shaderName(string value) { }

	// RVA: 0x22AF100 Offset: 0x22AF201 VA: 0x22AF100 Slot: 6
	public ProfileGroupSection[] get_groups() { }

	// RVA: 0x22AF160 Offset: 0x22AF261 VA: 0x22AF160 Slot: 5
	public ProfileFeatureSection[] get_features() { }

	// RVA: 0x22AF1C0 Offset: 0x22AF2C1 VA: 0x22AF1C0 Slot: 7
	public ProfileFeatureDefinition GetFeatureDefinition(string featureKey) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract ProfileFeatureSection[] ProfileFeatureSection() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract ProfileGroupSection[] ProfileDefinitionTable() { }

	// RVA: 0x22AF400 Offset: 0x22AF501 VA: 0x22AF400
	protected void .ctor() { }
}

