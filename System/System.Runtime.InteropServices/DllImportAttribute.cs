[AttributeUsageAttribute] // RVA: 0xB1F40 Offset: 0xB2041 VA: 0xB1F40
[ComVisibleAttribute] // RVA: 0xB1F40 Offset: 0xB2041 VA: 0xB1F40
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1310
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x18037C0 Offset: 0x18038C1 VA: 0x18037C0
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x1803A90 Offset: 0x1803B91 VA: 0x1803A90
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x18039D0 Offset: 0x1803AD1 VA: 0x18039D0
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x1803AC0 Offset: 0x1803BC1 VA: 0x1803AC0
	public void .ctor(string dllName) { }

	// RVA: 0x1803B00 Offset: 0x1803C01 VA: 0x1803B00
	public string get_Value() { }
}

