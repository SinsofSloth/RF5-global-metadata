[RequireComponent] // RVA: 0x11AA80 Offset: 0x11AB81 VA: 0x11AA80
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 4079
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x18
	private AxisEventData m_AxisEventData; // 0x20
	private EventSystem m_EventSystem; // 0x28
	private BaseEventData m_BaseEventData; // 0x30
	protected BaseInput m_InputOverride; // 0x38
	private BaseInput m_DefaultInput; // 0x40

	// Properties
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x1637920 Offset: 0x1637A21 VA: 0x1637920
	public BaseInput get_input() { }

	// RVA: 0x1637B70 Offset: 0x1637C71 VA: 0x1637B70
	public BaseInput get_inputOverride() { }

	// RVA: 0x1637B80 Offset: 0x1637C81 VA: 0x1637B80
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x1637B90 Offset: 0x1637C91 VA: 0x1637B90
	protected EventSystem get_eventSystem() { }

	// RVA: 0x1637BA0 Offset: 0x1637CA1 VA: 0x1637BA0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1637D90 Offset: 0x1637E91 VA: 0x1637D90 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process() { }

	// RVA: 0x1637DC0 Offset: 0x1637EC1 VA: 0x1637DC0
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x1637EF0 Offset: 0x1637FF1 VA: 0x1637EF0
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x1637FF0 Offset: 0x16380F1 VA: 0x1637FF0
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x16380F0 Offset: 0x16381F1 VA: 0x16380F0
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x16382E0 Offset: 0x16383E1 VA: 0x16382E0
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x1638940 Offset: 0x1638A41 VA: 0x1638940 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x1638AB0 Offset: 0x1638BB1 VA: 0x1638AB0 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x1638B60 Offset: 0x1638C61 VA: 0x1638B60 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1638B70 Offset: 0x1638C71 VA: 0x1638B70 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x1638BC0 Offset: 0x1638CC1 VA: 0x1638BC0 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x1638BD0 Offset: 0x1638CD1 VA: 0x1638BD0 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x1638BE0 Offset: 0x1638CE1 VA: 0x1638BE0 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x1638BF0 Offset: 0x1638CF1 VA: 0x1638BF0 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x1638C00 Offset: 0x1638D01 VA: 0x1638C00
	protected void .ctor() { }
}

