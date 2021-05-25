[AttributeUsageAttribute] // RVA: 0x126D60 Offset: 0x126E61 VA: 0x126D60
public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 4299
{
	// Fields
	private bool _autoCreate; // 0x10
	private bool _autoSearch; // 0x11
	private bool _editorOnly; // 0x12

	// Properties
	public bool AutoSearch { get; set; }
	public bool AutoCreate { get; set; }
	[ObsoleteAttribute] // RVA: 0x128550 Offset: 0x128651 VA: 0x128550
	public bool EditorOnly { get; set; }

	// Methods

	// RVA: 0x1A80300 Offset: 0x1A80401 VA: 0x1A80300
	public void .ctor(bool autoSearch) { }

	// RVA: 0x1A80340 Offset: 0x1A80441 VA: 0x1A80340
	public void .ctor() { }

	// RVA: 0x1A80350 Offset: 0x1A80451 VA: 0x1A80350
	public bool get_AutoSearch() { }

	// RVA: 0x1A80360 Offset: 0x1A80461 VA: 0x1A80360
	public void set_AutoSearch(bool value) { }

	// RVA: 0x1A80370 Offset: 0x1A80471 VA: 0x1A80370
	public bool get_AutoCreate() { }

	// RVA: 0x1A80380 Offset: 0x1A80481 VA: 0x1A80380
	public void set_AutoCreate(bool value) { }

	// RVA: 0x1A80390 Offset: 0x1A80491 VA: 0x1A80390
	public bool get_EditorOnly() { }

	// RVA: 0x1A803A0 Offset: 0x1A804A1 VA: 0x1A803A0
	public void set_EditorOnly(bool value) { }
}

