public class ProfileGroupDefinition // TypeDefIndex: 9655
{
	// Fields
	public ProfileGroupDefinition.GroupType type; // 0x10
	public ProfileGroupDefinition.FormatStyle formatStyle; // 0x14
	public ProfileGroupDefinition.RebuildType rebuildType; // 0x18
	public string propertyKey; // 0x20
	public string groupName; // 0x28
	public Color color; // 0x30
	public SpherePoint spherePoint; // 0x40
	public float minimumValue; // 0x48
	public float maximumValue; // 0x4C
	public float value; // 0x50
	public bool boolValue; // 0x54
	public Texture2D texture; // 0x58
	public string tooltip; // 0x60
	public string dependsOnFeature; // 0x68
	public bool dependsOnValue; // 0x70

	// Methods

	// RVA: 0x22B5FE0 Offset: 0x22B60E1 VA: 0x22B5FE0
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip) { }

	// RVA: 0x22B6020 Offset: 0x22B6121 VA: 0x22B6020
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6000 Offset: 0x22B6101 VA: 0x22B6000
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6040 Offset: 0x22B6141 VA: 0x22B6040
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, ProfileGroupDefinition.FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6190 Offset: 0x22B6291 VA: 0x22B6190
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string tooltip) { }

	// RVA: 0x22B62E0 Offset: 0x22B63E1 VA: 0x22B62E0
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B61B0 Offset: 0x22B62B1 VA: 0x22B61B0
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6300 Offset: 0x22B6401 VA: 0x22B6300
	public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip) { }

	// RVA: 0x22B6320 Offset: 0x22B6421 VA: 0x22B6320
	public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6460 Offset: 0x22B6561 VA: 0x22B6460
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string tooltip) { }

	// RVA: 0x22B6590 Offset: 0x22B6691 VA: 0x22B6590
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6480 Offset: 0x22B6581 VA: 0x22B6480
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B65B0 Offset: 0x22B66B1 VA: 0x22B65B0
	public static ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x22B6170 Offset: 0x22B6271 VA: 0x22B6170
	public void .ctor() { }
}

