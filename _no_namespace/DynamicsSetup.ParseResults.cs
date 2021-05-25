public class DynamicsSetup.ParseResults // TypeDefIndex: 9126
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x195FF0 Offset: 0x1960F1 VA: 0x195FF0
	private DynamicsSetup <Setup>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x196000 Offset: 0x196101 VA: 0x196000
	private List<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x18

	// Properties
	public DynamicsSetup Setup { get; set; }
	public List<DynamicsSetup.ParseMessage> Errors { get; set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x1FFD5E0 Offset: 0x1FFD6E1 VA: 0x1FFD5E0
	public void .ctor() { }

	// RVA: 0x1FFE190 Offset: 0x1FFE291 VA: 0x1FFE190
	public void .ctor(DynamicsSetup setup, IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x1FFD6E0 Offset: 0x1FFD7E1 VA: 0x1FFD6E0
	public static DynamicsSetup.ParseResults Failure(string error) { }

	// RVA: 0x1FFD8D0 Offset: 0x1FFD9D1 VA: 0x1FFD8D0
	public static DynamicsSetup.ParseResults Failure(IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4F10 Offset: 0x1B5011 VA: 0x1B4F10
	// RVA: 0x1FFE4B0 Offset: 0x1FFE5B1 VA: 0x1FFE4B0
	public DynamicsSetup get_Setup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4F20 Offset: 0x1B5021 VA: 0x1B4F20
	// RVA: 0x1FFE4C0 Offset: 0x1FFE5C1 VA: 0x1FFE4C0
	private void set_Setup(DynamicsSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4F30 Offset: 0x1B5031 VA: 0x1B4F30
	// RVA: 0x1FFE4D0 Offset: 0x1FFE5D1 VA: 0x1FFE4D0
	public List<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B4F40 Offset: 0x1B5041 VA: 0x1B4F40
	// RVA: 0x1FFE4E0 Offset: 0x1FFE5E1 VA: 0x1FFE4E0
	private void set_Errors(List<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x1FFE4F0 Offset: 0x1FFE5F1 VA: 0x1FFE4F0
	public bool get_HasErrors() { }

	// RVA: 0x1FFC800 Offset: 0x1FFC901 VA: 0x1FFC800
	public void LogErrors() { }
}

