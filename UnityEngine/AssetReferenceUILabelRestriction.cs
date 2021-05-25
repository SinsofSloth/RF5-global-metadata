[AttributeUsageAttribute] // RVA: 0x13DA20 Offset: 0x13DB21 VA: 0x13DA20
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction // TypeDefIndex: 5667
{
	// Fields
	public string[] m_AllowedLabels; // 0x10
	public string m_CachedToString; // 0x18

	// Methods

	// RVA: 0x1BD8830 Offset: 0x1BD8931 VA: 0x1BD8830
	public void .ctor(string[] allowedLabels) { }

	// RVA: 0x1BD8880 Offset: 0x1BD8981 VA: 0x1BD8880 Slot: 4
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x1BD8890 Offset: 0x1BD8991 VA: 0x1BD8890 Slot: 5
	public override bool ValidateAsset(string path) { }

	// RVA: 0x1BD88A0 Offset: 0x1BD89A1 VA: 0x1BD88A0 Slot: 3
	public override string ToString() { }
}

