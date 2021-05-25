[ComVisibleAttribute] // RVA: 0xAEB00 Offset: 0xAEC01 VA: 0xAEB00
[Serializable]
public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 678
{
	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x18A09C0 Offset: 0x18A0AC1 VA: 0x18A09C0
	public void .ctor(string path) { }

	// RVA: 0x189EB20 Offset: 0x189EC21 VA: 0x189EB20
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x18A0F70 Offset: 0x18A1071 VA: 0x18A0F70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A0CC0 Offset: 0x18A0DC1 VA: 0x18A0CC0
	private void Initialize() { }

	// RVA: 0x18A1130 Offset: 0x18A1231 VA: 0x18A1130 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x18A11E0 Offset: 0x18A12E1 VA: 0x18A11E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x189ECC0 Offset: 0x189EDC1 VA: 0x189ECC0
	public DirectoryInfo get_Parent() { }

	// RVA: 0x189ED60 Offset: 0x189EE61 VA: 0x189ED60
	public void Create() { }

	// RVA: 0x18A11F0 Offset: 0x18A12F1 VA: 0x18A11F0
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x18A1240 Offset: 0x18A1341 VA: 0x18A1240
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x18A13F0 Offset: 0x18A14F1 VA: 0x18A13F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18A0A40 Offset: 0x18A0B41 VA: 0x18A0A40
	internal void CheckPath(string path) { }
}

