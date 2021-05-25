[MonoTODOAttribute] // RVA: 0xB4060 Offset: 0xB4161 VA: 0xB4060
[ComVisibleAttribute] // RVA: 0xB4060 Offset: 0xB4161 VA: 0xB4060
[Serializable]
public class StackFrame // TypeDefIndex: 1475
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x19B4EB0 Offset: 0x19B4FB1 VA: 0x19B4EB0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x19B4EC0 Offset: 0x19B4FC1 VA: 0x19B4EC0
	public void .ctor() { }

	// RVA: 0x19B4F20 Offset: 0x19B5021 VA: 0x19B4F20
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B4F90 Offset: 0x19B5091 VA: 0x19B4F90 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x19B4FA0 Offset: 0x19B50A1 VA: 0x19B4FA0 Slot: 5
	public virtual string GetFileName() { }

	// RVA: 0x19B4FB0 Offset: 0x19B50B1 VA: 0x19B4FB0
	internal string GetSecureFileName() { }

	// RVA: 0x19B50A0 Offset: 0x19B51A1 VA: 0x19B50A0 Slot: 6
	public virtual int GetILOffset() { }

	// RVA: 0x19B50B0 Offset: 0x19B51B1 VA: 0x19B50B0 Slot: 7
	public virtual MethodBase GetMethod() { }

	// RVA: 0x19B50C0 Offset: 0x19B51C1 VA: 0x19B50C0 Slot: 8
	public virtual int GetNativeOffset() { }

	// RVA: 0x19B50D0 Offset: 0x19B51D1 VA: 0x19B50D0
	internal long GetMethodAddress() { }

	// RVA: 0x19B50E0 Offset: 0x19B51E1 VA: 0x19B50E0
	internal uint GetMethodIndex() { }

	// RVA: 0x19B50F0 Offset: 0x19B51F1 VA: 0x19B50F0
	internal string GetInternalMethodName() { }

	// RVA: 0x19B5100 Offset: 0x19B5201 VA: 0x19B5100 Slot: 3
	public override string ToString() { }
}

