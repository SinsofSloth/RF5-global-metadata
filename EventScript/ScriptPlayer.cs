public class ScriptPlayer // TypeDefIndex: 10428
{
	// Fields
	public float WaitTime; // 0x10
	private BinaryReader bin_; // 0x18
	private CommandBase now_; // 0x20
	private Action cb_end_; // 0x28
	private bool reader_start; // 0x30
	private bool first_; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x181890 Offset: 0x181991 VA: 0x181890
	private bool <Active>k__BackingField; // 0x32
	[CompilerGeneratedAttribute] // RVA: 0x1818A0 Offset: 0x1819A1 VA: 0x1818A0
	private bool <Exit>k__BackingField; // 0x33
	[CompilerGeneratedAttribute] // RVA: 0x1818B0 Offset: 0x1819B1 VA: 0x1818B0
	private bool <Pause>k__BackingField; // 0x34

	// Properties
	public bool Ready { get; }
	public bool Active { get; set; }
	public bool Exit { get; set; }
	public bool Pause { get; set; }

	// Methods

	// RVA: 0x20765D0 Offset: 0x20766D1 VA: 0x20765D0
	public void .ctor() { }

	// RVA: 0x2076680 Offset: 0x2076781 VA: 0x2076680
	public void .ctor(string name, Action cb_end) { }

	// RVA: 0x2077270 Offset: 0x2077371 VA: 0x2077270 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x20772D0 Offset: 0x20773D1 VA: 0x20772D0 Slot: 5
	public virtual void Load(string name, Action cb_end) { }

	// RVA: 0x20773A0 Offset: 0x20774A1 VA: 0x20773A0 Slot: 6
	public virtual void SetData(byte[] data) { }

	// RVA: 0x2077420 Offset: 0x2077521 VA: 0x2077420 Slot: 7
	public virtual void Clear() { }

	// RVA: 0x2076740 Offset: 0x2076841 VA: 0x2076740 Slot: 8
	public virtual void Start() { }

	// RVA: 0x20767D0 Offset: 0x20768D1 VA: 0x20767D0 Slot: 9
	public virtual void End() { }

	// RVA: 0x2075CD0 Offset: 0x2075DD1 VA: 0x2075CD0
	public bool get_Ready() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF2D0 Offset: 0x1AF3D1 VA: 0x1AF2D0
	// RVA: 0x2077480 Offset: 0x2077581 VA: 0x2077480
	public bool get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF2E0 Offset: 0x1AF3E1 VA: 0x1AF2E0
	// RVA: 0x2077490 Offset: 0x2077591 VA: 0x2077490
	private void set_Active(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF2F0 Offset: 0x1AF3F1 VA: 0x1AF2F0
	// RVA: 0x20774A0 Offset: 0x20775A1 VA: 0x20774A0
	public bool get_Exit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF300 Offset: 0x1AF401 VA: 0x1AF300
	// RVA: 0x20774B0 Offset: 0x20775B1 VA: 0x20774B0
	public void set_Exit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF310 Offset: 0x1AF411 VA: 0x1AF310
	// RVA: 0x20774C0 Offset: 0x20775C1 VA: 0x20774C0
	public bool get_Pause() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF320 Offset: 0x1AF421 VA: 0x1AF320
	// RVA: 0x20774D0 Offset: 0x20775D1 VA: 0x20774D0
	public void set_Pause(bool value) { }

	// RVA: 0x2077440 Offset: 0x2077541 VA: 0x2077440
	public void SetPos(int pos) { }

	// RVA: 0x2075CF0 Offset: 0x2075DF1 VA: 0x2075CF0
	public void Update() { }
}

