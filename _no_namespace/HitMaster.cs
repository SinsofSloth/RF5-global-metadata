public class HitMaster : MonoBehaviour // TypeDefIndex: 7619
{
	// Fields
	[SerializeField] // RVA: 0x1685C0 Offset: 0x1686C1 VA: 0x1685C0
	private CharID CharID; // 0x18
	[SerializeField] // RVA: 0x1685D0 Offset: 0x1686D1 VA: 0x1685D0
	private HitController[] hitControllers; // 0x20
	[SerializeField] // RVA: 0x1685E0 Offset: 0x1686E1 VA: 0x1685E0
	private HumanMotionType activeMotionType; // 0x28
	[SerializeField] // RVA: 0x1685F0 Offset: 0x1686F1 VA: 0x1685F0
	public HumanController Human; // 0x30

	// Properties
	public HitController[] HitControllers { get; }
	public HumanController HumanController { get; }

	// Methods

	// RVA: 0x2305200 Offset: 0x2305301 VA: 0x2305200
	public HitController[] get_HitControllers() { }

	// RVA: 0x2305210 Offset: 0x2305311 VA: 0x2305210
	public HumanController get_HumanController() { }

	// RVA: 0x23052D0 Offset: 0x23053D1 VA: 0x23052D0
	public void SetCharId(CharID charID) { }

	// RVA: 0x23052E0 Offset: 0x23053E1 VA: 0x23052E0
	public void ResetPosition(float position) { }

	// RVA: 0x23053E0 Offset: 0x23054E1 VA: 0x23053E0
	public void ResetScale(float scale) { }

	// RVA: 0x23054E0 Offset: 0x23055E1 VA: 0x23054E0
	public void SetMotionType(HumanMotionType motionType) { }

	// RVA: 0x23055D0 Offset: 0x23056D1 VA: 0x23055D0
	public HitController GetHitController() { }

	// RVA: 0x2305630 Offset: 0x2305731 VA: 0x2305630
	public HitController GetHitController(HumanMotionType motionType) { }

	// RVA: 0x2305670 Offset: 0x2305771 VA: 0x2305670
	private void Awake() { }

	// RVA: 0x2305730 Offset: 0x2305831 VA: 0x2305730
	public void .ctor() { }
}

