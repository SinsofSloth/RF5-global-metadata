[Serializable]
public abstract class IKSolver // TypeDefIndex: 9471
{
	// Fields
	[HideInInspector] // RVA: 0x17B030 Offset: 0x17B131 VA: 0x17B030
	public Vector3 IKPosition; // 0x10
	[TooltipAttribute] // RVA: 0x17B040 Offset: 0x17B141 VA: 0x17B040
	[RangeAttribute] // RVA: 0x17B040 Offset: 0x17B141 VA: 0x17B040
	public float IKPositionWeight; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17B0A0 Offset: 0x17B1A1 VA: 0x17B0A0
	private bool <initiated>k__BackingField; // 0x20
	public IKSolver.UpdateDelegate OnPreInitiate; // 0x28
	public IKSolver.UpdateDelegate OnPostInitiate; // 0x30
	public IKSolver.UpdateDelegate OnPreUpdate; // 0x38
	public IKSolver.UpdateDelegate OnPostUpdate; // 0x40
	protected bool firstInitiation; // 0x48
	[SerializeField] // RVA: 0x17B0B0 Offset: 0x17B1B1 VA: 0x17B0B0
	[HideInInspector] // RVA: 0x17B0B0 Offset: 0x17B1B1 VA: 0x17B0B0
	protected Transform root; // 0x50

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x257F960 Offset: 0x257FA61 VA: 0x257F960
	public bool IsValid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsValid(ref string message) { }

	// RVA: 0x257F9E0 Offset: 0x257FAE1 VA: 0x257F9E0
	public void Initiate(Transform root) { }

	// RVA: 0x257FD90 Offset: 0x257FE91 VA: 0x257FD90
	public void Update() { }

	// RVA: 0x257FE00 Offset: 0x257FF01 VA: 0x257FE00 Slot: 5
	public virtual Vector3 GetIKPosition() { }

	// RVA: 0x257FE10 Offset: 0x257FF11 VA: 0x257FE10
	public void SetIKPosition(Vector3 position) { }

	// RVA: 0x257FE20 Offset: 0x257FF21 VA: 0x257FE20
	public float GetIKPositionWeight() { }

	// RVA: 0x257FE30 Offset: 0x257FF31 VA: 0x257FE30
	public void SetIKPositionWeight(float weight) { }

	// RVA: 0x257FEC0 Offset: 0x257FFC1 VA: 0x257FEC0
	public Transform GetRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB470 Offset: 0x1AB571 VA: 0x1AB470
	// RVA: 0x257FED0 Offset: 0x257FFD1 VA: 0x257FED0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB480 Offset: 0x1AB581 VA: 0x1AB480
	// RVA: 0x257FEE0 Offset: 0x257FFE1 VA: 0x257FEE0
	private void set_initiated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IKSolver.Point[] GetPoints() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IKSolver.Point GetPoint(Transform transform) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FixTransforms() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StoreDefaultLocalState() { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnInitiate() { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnUpdate() { }

	// RVA: 0x257FEF0 Offset: 0x257FFF1 VA: 0x257FEF0
	protected void LogWarning(string message) { }

	// RVA: 0x257FF10 Offset: 0x2580011 VA: 0x257FF10
	public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones) { }

	// RVA: 0x2580050 Offset: 0x2580151 VA: 0x2580050
	public static bool HierarchyIsValid(IKSolver.Bone[] bones) { }

	// RVA: 0x2580100 Offset: 0x2580201 VA: 0x2580100
	protected static float PreSolveBones(ref IKSolver.Bone[] bones) { }

	// RVA: 0x25804A0 Offset: 0x25805A1 VA: 0x25804A0
	protected void .ctor() { }
}

