public class PlayerMover : MonoBehaviour // TypeDefIndex: 9077
{
	// Fields
	[TooltipAttribute] // RVA: 0x176770 Offset: 0x176871 VA: 0x176770
	public Streamer[] streamers; // 0x18
	[SpaceAttribute] // RVA: 0x1767B0 Offset: 0x1768B1 VA: 0x1767B0
	[TooltipAttribute] // RVA: 0x1767B0 Offset: 0x1768B1 VA: 0x1767B0
	public Transform player; // 0x20
	[TooltipAttribute] // RVA: 0x176800 Offset: 0x176901 VA: 0x176800
	public Transform safePosition; // 0x28
	[SpaceAttribute] // RVA: 0x176840 Offset: 0x176941 VA: 0x176840
	public UnityEvent onDone; // 0x30
	protected Vector3 savePosition; // 0x38
	protected Quaternion saveRotation; // 0x44
	protected float progress; // 0x54
	protected bool waitForPlayer; // 0x58
	protected bool playerMoved; // 0x59

	// Methods

	// RVA: 0x22027D0 Offset: 0x22028D1 VA: 0x22027D0
	private void Awake() { }

	// RVA: 0x2202830 Offset: 0x2202931 VA: 0x2202830
	private void Update() { }

	// RVA: 0x2202AB0 Offset: 0x2202BB1 VA: 0x2202AB0
	public void Done() { }

	// RVA: 0x2202B80 Offset: 0x2202C81 VA: 0x2202B80 Slot: 4
	public virtual void MovePlayer() { }

	// RVA: 0x2202BF0 Offset: 0x2202CF1 VA: 0x2202BF0
	public void .ctor() { }
}

