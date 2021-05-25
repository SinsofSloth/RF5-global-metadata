public class SwitchSaveController : SaveControllerBase // TypeDefIndex: 9905
{
	// Fields
	private Uid UserId; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x17F9D0 Offset: 0x17FAD1 VA: 0x17F9D0
	private bool <IsMount>k__BackingField; // 0x48
	private const string MountName = "save";
	private FileHandle FileHandle; // 0x50
	private SwitchSaveController.ErrorCheckData[] ErrorCheckDatas; // 0x58

	// Properties
	public bool IsMount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD320 Offset: 0x1AD421 VA: 0x1AD320
	// RVA: 0x20FA710 Offset: 0x20FA811 VA: 0x20FA710
	public bool get_IsMount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD330 Offset: 0x1AD431 VA: 0x1AD330
	// RVA: 0x20FA720 Offset: 0x20FA821 VA: 0x20FA720
	private void set_IsMount(bool value) { }

	// RVA: 0x20FA730 Offset: 0x20FA831 VA: 0x20FA730
	private bool GetError(Result result) { }

	// RVA: 0x20FA8B0 Offset: 0x20FA9B1 VA: 0x20FA8B0 Slot: 5
	public override string GetFilePath(string filename) { }

	// RVA: 0x20FA910 Offset: 0x20FAA11 VA: 0x20FA910 Slot: 6
	public override void Create() { }

	// RVA: 0x20FAB50 Offset: 0x20FAC51 VA: 0x20FAB50 Slot: 7
	public override void Destroy() { }

	// RVA: 0x20FAAB0 Offset: 0x20FABB1 VA: 0x20FAAB0
	private void Mount() { }

	// RVA: 0x20FABB0 Offset: 0x20FACB1 VA: 0x20FABB0
	private void UnMount() { }

	// RVA: 0x20FAC10 Offset: 0x20FAD11 VA: 0x20FAC10 Slot: 9
	public override void SaveData(string filename, byte[] savedata) { }

	// RVA: 0x20FAE60 Offset: 0x20FAF61 VA: 0x20FAE60 Slot: 10
	public override void LoadData(string filename, out byte[] savedata) { }

	// RVA: 0x20FB030 Offset: 0x20FB131 VA: 0x20FB030 Slot: 11
	public override void DeleteData(string filename) { }

	// RVA: 0x20FB180 Offset: 0x20FB281 VA: 0x20FB180 Slot: 12
	public override bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F9280 Offset: 0x20F9381 VA: 0x20F9280
	public void .ctor() { }
}

