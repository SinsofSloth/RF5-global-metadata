[Serializable]
public class EnvironmentSoundPointController : SEController // TypeDefIndex: 8258
{
	// Fields
	[SerializeField] // RVA: 0x16E6A0 Offset: 0x16E7A1 VA: 0x16E6A0
	private string SoundIDString; // 0x78
	[SerializeField] // RVA: 0x16E6B0 Offset: 0x16E7B1 VA: 0x16E6B0
	private SoundID SerializeSoundID; // 0x80
	[SerializeField] // RVA: 0x16E6C0 Offset: 0x16E7C1 VA: 0x16E6C0
	private float m_FadeTime; // 0x84
	[SerializeField] // RVA: 0x16E6D0 Offset: 0x16E7D1 VA: 0x16E6D0
	private float IntervalMin; // 0x88
	[SerializeField] // RVA: 0x16E6E0 Offset: 0x16E7E1 VA: 0x16E6E0
	private float IntervalMax; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x16E6F0 Offset: 0x16E7F1 VA: 0x16E6F0
	private float <Interval>k__BackingField; // 0x90
	private bool InsidePlayer; // 0x94
	private SphereCollider SphereCollider; // 0x98
	private bool IsActive; // 0xA0
	private float DoneTime; // 0xA4

	// Properties
	private float Interval { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A66D0 Offset: 0x1A67D1 VA: 0x1A66D0
	// RVA: 0x2020A20 Offset: 0x2020B21 VA: 0x2020A20
	private float get_Interval() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A66E0 Offset: 0x1A67E1 VA: 0x1A66E0
	// RVA: 0x2020A30 Offset: 0x2020B31 VA: 0x2020A30
	private void set_Interval(float value) { }

	// RVA: 0x2020A40 Offset: 0x2020B41 VA: 0x2020A40 Slot: 6
	protected override void Awake() { }

	// RVA: 0x2020AD0 Offset: 0x2020BD1 VA: 0x2020AD0
	protected void Start() { }

	// RVA: 0x2020BA0 Offset: 0x2020CA1 VA: 0x2020BA0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x2020C30 Offset: 0x2020D31 VA: 0x2020C30 Slot: 5
	protected override AudioSource ReadyAudioSourceComponent() { }

	// RVA: 0x2020C80 Offset: 0x2020D81 VA: 0x2020C80
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2020D30 Offset: 0x2020E31 VA: 0x2020D30
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x2020DD0 Offset: 0x2020ED1 VA: 0x2020DD0 Slot: 13
	protected override void SetupBeforePlayByDataTable() { }

	// RVA: 0x2020F00 Offset: 0x2021001 VA: 0x2020F00 Slot: 20
	protected override void Done_Enter() { }

	// RVA: 0x2020F40 Offset: 0x2021041 VA: 0x2020F40 Slot: 21
	protected virtual void Done_Update() { }

	// RVA: 0x2020FE0 Offset: 0x20210E1 VA: 0x2020FE0
	public void .ctor() { }
}

