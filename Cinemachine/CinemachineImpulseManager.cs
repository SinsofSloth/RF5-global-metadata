[DocumentationSortingAttribute] // RVA: 0x12F1C0 Offset: 0x12F2C1 VA: 0x12F1C0
public class CinemachineImpulseManager // TypeDefIndex: 4886
{
	// Fields
	private static CinemachineImpulseManager sInstance; // 0x0
	private const float Epsilon = 0.0001;
	private List<CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents; // 0x10
	private List<CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1357A0 Offset: 0x1358A1 VA: 0x1357A0
	private bool <IgnoreTimeScale>k__BackingField; // 0x20

	// Properties
	public static CinemachineImpulseManager Instance { get; }
	public bool IgnoreTimeScale { get; set; }
	public float CurrentTime { get; }

	// Methods

	// RVA: 0x172CA30 Offset: 0x172CB31 VA: 0x172CA30
	private void .ctor() { }

	// RVA: 0x172BD50 Offset: 0x172BE51 VA: 0x172BD50
	public static CinemachineImpulseManager get_Instance() { }

	// RVA: 0x172C670 Offset: 0x172C771 VA: 0x172C670
	public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	[CompilerGeneratedAttribute] // RVA: 0x137300 Offset: 0x137401 VA: 0x137300
	// RVA: 0x172D220 Offset: 0x172D321 VA: 0x172D220
	public bool get_IgnoreTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x137310 Offset: 0x137411 VA: 0x137310
	// RVA: 0x172D230 Offset: 0x172D331 VA: 0x172D230
	public void set_IgnoreTimeScale(bool value) { }

	// RVA: 0x172D240 Offset: 0x172D341 VA: 0x172D240
	public float get_CurrentTime() { }

	// RVA: 0x172BE40 Offset: 0x172BF41 VA: 0x172BE40
	public CinemachineImpulseManager.ImpulseEvent NewImpulseEvent() { }

	// RVA: 0x172BFA0 Offset: 0x172C0A1 VA: 0x172BFA0
	public void AddImpulseEvent(CinemachineImpulseManager.ImpulseEvent e) { }

	// RVA: 0x172D2E0 Offset: 0x172D3E1 VA: 0x172D2E0
	public void Clear() { }

	// RVA: 0x172D3A0 Offset: 0x172D4A1 VA: 0x172D3A0
	private static void .cctor() { }
}

