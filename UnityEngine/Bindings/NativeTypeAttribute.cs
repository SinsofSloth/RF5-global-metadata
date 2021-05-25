[AttributeUsageAttribute] // RVA: 0xC1B80 Offset: 0xC1C81 VA: 0xC1B80
[VisibleToOtherModulesAttribute] // RVA: 0xC1B80 Offset: 0xC1C81 VA: 0xC1B80
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 2768
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xC2200 Offset: 0xC2301 VA: 0xC2200
	[DebuggerBrowsableAttribute] // RVA: 0xC2200 Offset: 0xC2301 VA: 0xC2200
	private string <Header>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xC2240 Offset: 0xC2341 VA: 0xC2240
	[DebuggerBrowsableAttribute] // RVA: 0xC2240 Offset: 0xC2341 VA: 0xC2240
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0xC2280 Offset: 0xC2381 VA: 0xC2280
	[CompilerGeneratedAttribute] // RVA: 0xC2280 Offset: 0xC2381 VA: 0xC2280
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xC2590 Offset: 0xC2691 VA: 0xC2590
	// RVA: 0x1BDAFB0 Offset: 0x1BDB0B1 VA: 0x1BDAFB0 Slot: 4
	public void set_Header(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0xC25A0 Offset: 0xC26A1 VA: 0xC25A0
	// RVA: 0x1BDAFC0 Offset: 0x1BDB0C1 VA: 0x1BDAFC0
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0xC25B0 Offset: 0xC26B1 VA: 0xC25B0
	// RVA: 0x1BDAFD0 Offset: 0x1BDB0D1 VA: 0x1BDAFD0 Slot: 5
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x1BDAFE0 Offset: 0x1BDB0E1 VA: 0x1BDAFE0
	public void .ctor() { }

	// RVA: 0x1BDB010 Offset: 0x1BDB111 VA: 0x1BDB010
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x1BDB040 Offset: 0x1BDB141 VA: 0x1BDB040
	public void .ctor(string header) { }

	// RVA: 0x1BDB140 Offset: 0x1BDB241 VA: 0x1BDB140
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

