[Serializable]
public class ProfileFeatureDefinition // TypeDefIndex: 9660
{
	// Fields
	public string featureKey; // 0x10
	public string[] featureKeys; // 0x18
	public ProfileFeatureDefinition.FeatureType featureType; // 0x20
	public string shaderKeyword; // 0x28
	public string[] shaderKeywords; // 0x30
	public string[] dropdownLabels; // 0x38
	public int dropdownSelectedIndex; // 0x40
	public string name; // 0x48
	public bool value; // 0x50
	public string tooltip; // 0x58
	public string dependsOnFeature; // 0x60
	public bool dependsOnValue; // 0x68
	public bool isShaderKeywordFeature; // 0x69

	// Methods

	// RVA: 0x22B5C60 Offset: 0x22B5D61 VA: 0x22B5C60
	public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B5D70 Offset: 0x22B5E71 VA: 0x22B5D70
	public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B5E90 Offset: 0x22B5F91 VA: 0x22B5E90
	public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B5D60 Offset: 0x22B5E61 VA: 0x22B5D60
	public void .ctor() { }
}

