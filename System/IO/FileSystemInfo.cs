[ComVisibleAttribute] // RVA: 0xAE960 Offset: 0xAEA61 VA: 0xAE960
[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 651
{
	// Fields
	internal MonoIOStat _data; // 0x18
	internal int _dataInitialised; // 0x40
	private const int ERROR_INVALID_PARAMETER = 87;
	internal const int ERROR_ACCESS_DENIED = 5;
	protected string FullPath; // 0x48
	protected string OriginalPath; // 0x50
	private string _displayPath; // 0x58

	// Properties
	public virtual string FullName { get; }
	public abstract string Name { get; }
	public abstract bool Exists { get; }
	internal string DisplayPath { get; set; }

	// Methods

	// RVA: 0x18A09D0 Offset: 0x18A0AD1 VA: 0x18A09D0
	protected void .ctor() { }

	// RVA: 0x18A0FA0 Offset: 0x18A10A1 VA: 0x18A0FA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18AA950 Offset: 0x18AAA51 VA: 0x18AA950 Slot: 7
	public virtual string get_FullName() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists() { }

	// RVA: 0x18A11A0 Offset: 0x18A12A1 VA: 0x18A11A0
	public void Refresh() { }

	[ComVisibleAttribute] // RVA: 0xB86B0 Offset: 0xB87B1 VA: 0xB86B0
	// RVA: 0x18AA960 Offset: 0x18AAA61 VA: 0x18AA960 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18AAA50 Offset: 0x18AAB51 VA: 0x18AAA50
	internal string get_DisplayPath() { }

	// RVA: 0x18AAA60 Offset: 0x18AAB61 VA: 0x18AAA60
	internal void set_DisplayPath(string value) { }
}

