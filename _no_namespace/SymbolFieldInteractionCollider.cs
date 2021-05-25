public class SymbolFieldInteractionCollider : InteractionColliderBase // TypeDefIndex: 8308
{
	// Fields
	[SerializeField] // RVA: 0x16EC00 Offset: 0x16ED01 VA: 0x16EC00
	private UnityEvent OnChangeCurrentInteraction; // 0x38
	private const int FOCUS_MAX = 10;
	private FocusInterface[] _CurrentFocus; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x16EC10 Offset: 0x16ED11 VA: 0x16EC10
	private Collider[] <CurrentFocusCollider>k__BackingField; // 0x48
	protected const int FocusBufferMaxSize = 256;
	[TupleElementNamesAttribute] // RVA: 0x16EC20 Offset: 0x16ED21 VA: 0x16EC20
	private ValueTuple<Collider, FocusInterface, Vector3>[] m_WorkList; // 0x50
	protected Dictionary<Collider, FocusInterface> m_FocusList; // 0x58
	private static SymbolFieldInteractionCollider.Comparer m_Comparer; // 0x0
	private FocusInterface[] newFocus; // 0x60
	private Collider[] newFocusCollider; // 0x68

	// Properties
	public FocusInterface[] CurrentFocus { get; set; }
	public Collider[] CurrentFocusCollider { get; set; }

	// Methods

	// RVA: 0x1C63E30 Offset: 0x1C63F31 VA: 0x1C63E30
	public FocusInterface[] get_CurrentFocus() { }

	// RVA: 0x1C63E40 Offset: 0x1C63F41 VA: 0x1C63E40
	private void set_CurrentFocus(FocusInterface[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6CC0 Offset: 0x1A6DC1 VA: 0x1A6CC0
	// RVA: 0x1C63E60 Offset: 0x1C63F61 VA: 0x1C63E60
	public Collider[] get_CurrentFocusCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6CD0 Offset: 0x1A6DD1 VA: 0x1A6CD0
	// RVA: 0x1C63E70 Offset: 0x1C63F71 VA: 0x1C63E70
	private void set_CurrentFocusCollider(Collider[] value) { }

	// RVA: 0x1C63E80 Offset: 0x1C63F81 VA: 0x1C63E80
	private void OnDisable() { }

	// RVA: 0x1C64020 Offset: 0x1C64121 VA: 0x1C64020
	public void DoUpdate() { }

	// RVA: 0x1C63E90 Offset: 0x1C63F91 VA: 0x1C63E90
	public void ClearFocus() { }

	// RVA: 0x1C65000 Offset: 0x1C65101 VA: 0x1C65000
	public void .ctor() { }

	// RVA: 0x1C65190 Offset: 0x1C65291 VA: 0x1C65190
	private static void .cctor() { }
}

