[AttributeUsageAttribute] // RVA: 0xABB30 Offset: 0xABC31 VA: 0xABB30
[ComVisibleAttribute] // RVA: 0xABB30 Offset: 0xABC31 VA: 0xABB30
[Serializable]
public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 186
{
	// Fields
	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x1851C20 Offset: 0x1851D21 VA: 0x1851C20
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x1851C60 Offset: 0x1851D61 VA: 0x1851C60
	public bool get_AllowMultiple() { }

	// RVA: 0x1851C70 Offset: 0x1851D71 VA: 0x1851C70
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x1851C80 Offset: 0x1851D81 VA: 0x1851C80
	public bool get_Inherited() { }

	// RVA: 0x1851C90 Offset: 0x1851D91 VA: 0x1851C90
	public void set_Inherited(bool value) { }

	// RVA: 0x1851CA0 Offset: 0x1851DA1 VA: 0x1851CA0
	private static void .cctor() { }
}

