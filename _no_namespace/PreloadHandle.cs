public abstract class PreloadHandle // TypeDefIndex: 7692
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x168A40 Offset: 0x168B41 VA: 0x168A40
	private PreloadHandle.STATE <State>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x168A50 Offset: 0x168B51 VA: 0x168A50
	private string <Key>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x168A60 Offset: 0x168B61 VA: 0x168A60
	private int <Priority>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x168A70 Offset: 0x168B71 VA: 0x168A70
	private bool <IsLoading>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x168A80 Offset: 0x168B81 VA: 0x168A80
	private bool <IsDone>k__BackingField; // 0x25
	[CompilerGeneratedAttribute] // RVA: 0x168A90 Offset: 0x168B91 VA: 0x168A90
	private bool <IsSuccess>k__BackingField; // 0x26

	// Properties
	public PreloadHandle.STATE State { get; set; }
	public string Key { get; set; }
	public int Priority { get; set; }
	public bool IsLoading { get; set; }
	public bool IsDone { get; set; }
	public bool IsSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2660 Offset: 0x1A2761 VA: 0x1A2660
	// RVA: 0x2775870 Offset: 0x2775971 VA: 0x2775870
	public PreloadHandle.STATE get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2670 Offset: 0x1A2771 VA: 0x1A2670
	// RVA: 0x2775880 Offset: 0x2775981 VA: 0x2775880
	protected void set_State(PreloadHandle.STATE value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2680 Offset: 0x1A2781 VA: 0x1A2680
	// RVA: 0x2775890 Offset: 0x2775991 VA: 0x2775890
	public string get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2690 Offset: 0x1A2791 VA: 0x1A2690
	// RVA: 0x27758A0 Offset: 0x27759A1 VA: 0x27758A0
	protected void set_Key(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26A0 Offset: 0x1A27A1 VA: 0x1A26A0
	// RVA: 0x27758B0 Offset: 0x27759B1 VA: 0x27758B0
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26B0 Offset: 0x1A27B1 VA: 0x1A26B0
	// RVA: 0x27758C0 Offset: 0x27759C1 VA: 0x27758C0
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26C0 Offset: 0x1A27C1 VA: 0x1A26C0
	// RVA: 0x27758D0 Offset: 0x27759D1 VA: 0x27758D0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26D0 Offset: 0x1A27D1 VA: 0x1A26D0
	// RVA: 0x27758E0 Offset: 0x27759E1 VA: 0x27758E0
	protected void set_IsLoading(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26E0 Offset: 0x1A27E1 VA: 0x1A26E0
	// RVA: 0x27758F0 Offset: 0x27759F1 VA: 0x27758F0
	public bool get_IsDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A26F0 Offset: 0x1A27F1 VA: 0x1A26F0
	// RVA: 0x2775900 Offset: 0x2775A01 VA: 0x2775900
	protected void set_IsDone(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2700 Offset: 0x1A2801 VA: 0x1A2700
	// RVA: 0x2775910 Offset: 0x2775A11 VA: 0x2775910
	public bool get_IsSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2710 Offset: 0x1A2811 VA: 0x1A2710
	// RVA: 0x2775920 Offset: 0x2775A21 VA: 0x2775920
	protected void set_IsSuccess(bool value) { }

	// RVA: 0x2775930 Offset: 0x2775A31 VA: 0x2775930
	protected void Entry(string key, int priority) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Remove() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool LoadAsync(bool load = True) { }

	// RVA: 0x2775970 Offset: 0x2775A71 VA: 0x2775970
	protected void .ctor() { }
}

