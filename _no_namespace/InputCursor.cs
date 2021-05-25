public class InputCursor : SingletonMonoBehaviour<InputCursor> // TypeDefIndex: 7626
{
	// Fields
	private Text textComponent; // 0x18
	private StringBuilder stringBuilder; // 0x20
	private TouchScreenState1 touchScreenState; // 0x28
	private float Moved; // 0x60
	private Vector3 touchedPos; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x168750 Offset: 0x168851 VA: 0x168750
	private TouchState <state>k__BackingField; // 0x70

	// Properties
	public TouchState state { get; set; }
	public bool IsTouching { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2280 Offset: 0x1A2381 VA: 0x1A2280
	// RVA: 0x20CAA40 Offset: 0x20CAB41 VA: 0x20CAA40
	public TouchState get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2290 Offset: 0x1A2391 VA: 0x1A2290
	// RVA: 0x20CAA50 Offset: 0x20CAB51 VA: 0x20CAA50
	private void set_state(TouchState value) { }

	// RVA: 0x20CAA60 Offset: 0x20CAB61 VA: 0x20CAA60
	public bool get_IsTouching() { }

	// RVA: 0x20CAA70 Offset: 0x20CAB71 VA: 0x20CAA70
	public Vector3 GetTouchPos() { }

	// RVA: 0x20CAB90 Offset: 0x20CAC91 VA: 0x20CAB90
	private void UpdateState() { }

	// RVA: 0x20CAE20 Offset: 0x20CAF21 VA: 0x20CAE20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20CAE70 Offset: 0x20CAF71 VA: 0x20CAE70
	private void Update() { }

	// RVA: 0x20CAEA0 Offset: 0x20CAFA1 VA: 0x20CAEA0
	private void Start() { }

	// RVA: 0x20CAED0 Offset: 0x20CAFD1 VA: 0x20CAED0
	public void .ctor() { }
}

