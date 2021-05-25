public class EnvironmentSoundController : SEController // TypeDefIndex: 9867
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17F980 Offset: 0x17FA81 VA: 0x17F980
	private EnvironmentSoundDataTable <DataTable>k__BackingField; // 0x78
	public float Interval; // 0x80
	public float IntervalMin; // 0x84
	public float IntervalMax; // 0x88
	public bool MarkRemove; // 0x8C
	private float DoneTime; // 0x90

	// Properties
	public EnvironmentSoundDataTable DataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD260 Offset: 0x1AD361 VA: 0x1AD260
	// RVA: 0x1DA82C0 Offset: 0x1DA83C1 VA: 0x1DA82C0
	public EnvironmentSoundDataTable get_DataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD270 Offset: 0x1AD371 VA: 0x1AD270
	// RVA: 0x1DA82D0 Offset: 0x1DA83D1 VA: 0x1DA82D0
	public void set_DataTable(EnvironmentSoundDataTable value) { }

	// RVA: 0x1DA82E0 Offset: 0x1DA83E1 VA: 0x1DA82E0
	public bool IsCondition() { }

	// RVA: 0x1DA84F0 Offset: 0x1DA85F1 VA: 0x1DA84F0 Slot: 10
	public override void DoPlay(SoundID id, int priority = 0) { }

	// RVA: 0x1DA8720 Offset: 0x1DA8821 VA: 0x1DA8720 Slot: 13
	protected override void SetupBeforePlayByDataTable() { }

	// RVA: 0x1DA8810 Offset: 0x1DA8911 VA: 0x1DA8810 Slot: 16
	protected override void Play_Update() { }

	// RVA: 0x1DA88B0 Offset: 0x1DA89B1 VA: 0x1DA88B0 Slot: 20
	protected override void Done_Enter() { }

	// RVA: 0x1DA89E0 Offset: 0x1DA8AE1 VA: 0x1DA89E0 Slot: 21
	protected virtual void Done_Update() { }

	// RVA: 0x1DA8630 Offset: 0x1DA8731 VA: 0x1DA8630
	private void FrightenedMotion(SoundID id) { }

	// RVA: 0x1DA8AA0 Offset: 0x1DA8BA1 VA: 0x1DA8AA0
	public void .ctor() { }
}

