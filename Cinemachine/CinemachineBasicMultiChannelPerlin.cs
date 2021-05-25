[DocumentationSortingAttribute] // RVA: 0x12E920 Offset: 0x12EA21 VA: 0x12E920
[AddComponentMenu] // RVA: 0x12E920 Offset: 0x12EA21 VA: 0x12E920
[SaveDuringPlayAttribute] // RVA: 0x12E920 Offset: 0x12EA21 VA: 0x12E920
public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 4783
{
	// Fields
	[TooltipAttribute] // RVA: 0x131F90 Offset: 0x132091 VA: 0x131F90
	[FormerlySerializedAsAttribute] // RVA: 0x131F90 Offset: 0x132091 VA: 0x131F90
	[NoiseSettingsPropertyAttribute] // RVA: 0x131F90 Offset: 0x132091 VA: 0x131F90
	public NoiseSettings m_NoiseProfile; // 0x50
	[TooltipAttribute] // RVA: 0x132000 Offset: 0x132101 VA: 0x132000
	public Vector3 m_PivotOffset; // 0x58
	[TooltipAttribute] // RVA: 0x132040 Offset: 0x132141 VA: 0x132040
	public float m_AmplitudeGain; // 0x64
	[TooltipAttribute] // RVA: 0x132080 Offset: 0x132181 VA: 0x132080
	public float m_FrequencyGain; // 0x68
	private bool mInitialized; // 0x6C
	private float mNoiseTime; // 0x70
	[SerializeField] // RVA: 0x1320C0 Offset: 0x1321C1 VA: 0x1320C0
	[HideInInspector] // RVA: 0x1320C0 Offset: 0x1321C1 VA: 0x1320C0
	private Vector3 mNoiseOffsets; // 0x74

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1888530 Offset: 0x1888631 VA: 0x1888530 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x18885C0 Offset: 0x18886C1 VA: 0x18885C0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x18885D0 Offset: 0x18886D1 VA: 0x18885D0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1888F10 Offset: 0x1889011 VA: 0x1888F10
	public void ReSeed() { }

	// RVA: 0x1888D10 Offset: 0x1888E11 VA: 0x1888D10
	private void Initialize() { }

	// RVA: 0x1888FC0 Offset: 0x18890C1 VA: 0x1888FC0
	public void .ctor() { }
}

