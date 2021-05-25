[ComVisibleAttribute] // RVA: 0xAE900 Offset: 0xAEA01 VA: 0xAE900
[Serializable]
public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 641
{
	// Fields
	private string _name; // 0x60

	// Properties
	public override string Name { get; }
	public long Length { get; }
	public override bool Exists { get; }

	// Methods

	// RVA: 0x18A3440 Offset: 0x18A3541 VA: 0x18A3440
	public void .ctor(string fileName) { }

	// RVA: 0x18A3530 Offset: 0x18A3631 VA: 0x18A3530
	private void Init(string fileName, bool checkHost) { }

	// RVA: 0x18A36C0 Offset: 0x18A37C1 VA: 0x18A36C0
	private string GetDisplayPath(string originalPath) { }

	// RVA: 0x18A36D0 Offset: 0x18A37D1 VA: 0x18A36D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18A3770 Offset: 0x18A3871 VA: 0x18A3770 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18A3780 Offset: 0x18A3881 VA: 0x18A3780
	public long get_Length() { }

	// RVA: 0x18A3800 Offset: 0x18A3901 VA: 0x18A3800 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x18A3910 Offset: 0x18A3A11 VA: 0x18A3910
	public FileStream Open(FileMode mode, FileAccess access) { }

	// RVA: 0x18A39B0 Offset: 0x18A3AB1 VA: 0x18A39B0
	public FileStream Open(FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x18A3A50 Offset: 0x18A3B51 VA: 0x18A3A50 Slot: 3
	public override string ToString() { }
}

