public abstract class DLC // TypeDefIndex: 6897
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FF40 Offset: 0x160041 VA: 0x15FF40
	private List<DLCID> <OnFlags>k__BackingField; // 0x10
	protected Coroutine UpdateCoroutine; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15FF50 Offset: 0x160051 VA: 0x15FF50
	private Action<DLCID[]> <OnComplete>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15FF60 Offset: 0x160061 VA: 0x15FF60
	private static DLCDataTable <DLCDataTable>k__BackingField; // 0x0

	// Properties
	public List<DLCID> OnFlags { get; set; }
	protected Action<DLCID[]> OnComplete { get; set; }
	protected static DLCDataTable DLCDataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DB50 Offset: 0x19DC51 VA: 0x19DB50
	// RVA: 0x1CA5FD0 Offset: 0x1CA60D1 VA: 0x1CA5FD0
	public List<DLCID> get_OnFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB60 Offset: 0x19DC61 VA: 0x19DB60
	// RVA: 0x1CA5FE0 Offset: 0x1CA60E1 VA: 0x1CA5FE0
	protected void set_OnFlags(List<DLCID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB70 Offset: 0x19DC71 VA: 0x19DB70
	// RVA: 0x1CA5FF0 Offset: 0x1CA60F1 VA: 0x1CA5FF0
	protected Action<DLCID[]> get_OnComplete() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB80 Offset: 0x19DC81 VA: 0x19DB80
	// RVA: 0x1CA6000 Offset: 0x1CA6101 VA: 0x1CA6000
	protected void set_OnComplete(Action<DLCID[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB90 Offset: 0x19DC91 VA: 0x19DB90
	// RVA: 0x1CA6010 Offset: 0x1CA6111 VA: 0x1CA6010
	protected static DLCDataTable get_DLCDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DBA0 Offset: 0x19DCA1 VA: 0x19DBA0
	// RVA: 0x1CA6080 Offset: 0x1CA6181 VA: 0x1CA6080
	protected static void set_DLCDataTable(DLCDataTable value) { }

	// RVA: 0x1CA60F0 Offset: 0x1CA61F1 VA: 0x1CA60F0
	public static DLC Create() { }

	// RVA: 0x1CA6610 Offset: 0x1CA6711 VA: 0x1CA6610
	protected void .ctor() { }

	// RVA: 0x1CA66B0 Offset: 0x1CA67B1 VA: 0x1CA66B0 Slot: 4
	public virtual void Destroy() { }

	// RVA: 0x1CA6760 Offset: 0x1CA6861 VA: 0x1CA6760 Slot: 5
	public virtual void CheckContents(Action<DLCID[]> onComplete) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IEnumerator Update() { }

	// RVA: 0x1CA67B0 Offset: 0x1CA68B1 VA: 0x1CA67B0
	protected void SpecialFlagOn() { }

	// RVA: 0x1CA6900 Offset: 0x1CA6A01 VA: 0x1CA6900
	private static void .cctor() { }
}

