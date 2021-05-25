public class ParticleDestroy : MonoBehaviour // TypeDefIndex: 7113
{
	// Fields
	private float m_Elapsed; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x162EE0 Offset: 0x162FE1 VA: 0x162EE0
	private ParticleSystem[] <ParticleSystems>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x162EF0 Offset: 0x162FF1 VA: 0x162EF0
	private Transform <Target>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x162F00 Offset: 0x163001 VA: 0x162F00
	private bool <IsTargetMode>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x162F10 Offset: 0x163011 VA: 0x162F10
	private bool IsPrefabAttach; // 0x31
	[SerializeField] // RVA: 0x162F20 Offset: 0x163021 VA: 0x162F20
	public bool IsAutoVelocity; // 0x32
	[SerializeField] // RVA: 0x162F30 Offset: 0x163031 VA: 0x162F30
	private bool IsUseScale; // 0x33
	[CompilerGeneratedAttribute] // RVA: 0x162F40 Offset: 0x163041 VA: 0x162F40
	private ParticleDestroy.State <m_State>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x162F50 Offset: 0x163051 VA: 0x162F50
	private float <MaxLifeTime>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x162F60 Offset: 0x163061 VA: 0x162F60
	private float <MaxDuration>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x162F70 Offset: 0x163071 VA: 0x162F70
	private bool <IsLoopMode>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x162F80 Offset: 0x163081 VA: 0x162F80
	private Vector3 <OffsetPos>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x162F90 Offset: 0x163091 VA: 0x162F90
	private Quaternion <OffsetRote>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x162FA0 Offset: 0x1630A1 VA: 0x162FA0
	private Vector3 <OffsetScale>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x162FB0 Offset: 0x1630B1 VA: 0x162FB0
	private Vector3 <Velocity>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x162FC0 Offset: 0x1630C1 VA: 0x162FC0
	private Vector3 <PrevPos>k__BackingField; // 0x78

	// Properties
	private ParticleSystem[] ParticleSystems { get; set; }
	private Transform Target { get; set; }
	private bool IsTargetMode { get; set; }
	private ParticleDestroy.State m_State { get; set; }
	public float MaxLifeTime { get; set; }
	public float MaxDuration { get; set; }
	public bool IsLoopMode { get; set; }
	public Vector3 OffsetPos { get; set; }
	public Quaternion OffsetRote { get; set; }
	public Vector3 OffsetScale { get; set; }
	private Vector3 Velocity { get; set; }
	private Vector3 PrevPos { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DDE0 Offset: 0x19DEE1 VA: 0x19DDE0
	// RVA: 0x21BD0E0 Offset: 0x21BD1E1 VA: 0x21BD0E0
	private ParticleSystem[] get_ParticleSystems() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DDF0 Offset: 0x19DEF1 VA: 0x19DDF0
	// RVA: 0x21BD0F0 Offset: 0x21BD1F1 VA: 0x21BD0F0
	private void set_ParticleSystems(ParticleSystem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE00 Offset: 0x19DF01 VA: 0x19DE00
	// RVA: 0x21BD100 Offset: 0x21BD201 VA: 0x21BD100
	private Transform get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE10 Offset: 0x19DF11 VA: 0x19DE10
	// RVA: 0x21BD110 Offset: 0x21BD211 VA: 0x21BD110
	private void set_Target(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE20 Offset: 0x19DF21 VA: 0x19DE20
	// RVA: 0x21BD120 Offset: 0x21BD221 VA: 0x21BD120
	private bool get_IsTargetMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE30 Offset: 0x19DF31 VA: 0x19DE30
	// RVA: 0x21BD130 Offset: 0x21BD231 VA: 0x21BD130
	private void set_IsTargetMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE40 Offset: 0x19DF41 VA: 0x19DE40
	// RVA: 0x21BD140 Offset: 0x21BD241 VA: 0x21BD140
	private ParticleDestroy.State get_m_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE50 Offset: 0x19DF51 VA: 0x19DE50
	// RVA: 0x21BD150 Offset: 0x21BD251 VA: 0x21BD150
	private void set_m_State(ParticleDestroy.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE60 Offset: 0x19DF61 VA: 0x19DE60
	// RVA: 0x21BD160 Offset: 0x21BD261 VA: 0x21BD160
	public float get_MaxLifeTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE70 Offset: 0x19DF71 VA: 0x19DE70
	// RVA: 0x21BD170 Offset: 0x21BD271 VA: 0x21BD170
	private void set_MaxLifeTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE80 Offset: 0x19DF81 VA: 0x19DE80
	// RVA: 0x21BD180 Offset: 0x21BD281 VA: 0x21BD180
	public float get_MaxDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DE90 Offset: 0x19DF91 VA: 0x19DE90
	// RVA: 0x21BD190 Offset: 0x21BD291 VA: 0x21BD190
	public void set_MaxDuration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DEA0 Offset: 0x19DFA1 VA: 0x19DEA0
	// RVA: 0x21BD1A0 Offset: 0x21BD2A1 VA: 0x21BD1A0
	public bool get_IsLoopMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DEB0 Offset: 0x19DFB1 VA: 0x19DEB0
	// RVA: 0x21BD1B0 Offset: 0x21BD2B1 VA: 0x21BD1B0
	public void set_IsLoopMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DEC0 Offset: 0x19DFC1 VA: 0x19DEC0
	// RVA: 0x21BD1C0 Offset: 0x21BD2C1 VA: 0x21BD1C0
	public Vector3 get_OffsetPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DED0 Offset: 0x19DFD1 VA: 0x19DED0
	// RVA: 0x21BD1D0 Offset: 0x21BD2D1 VA: 0x21BD1D0
	public void set_OffsetPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DEE0 Offset: 0x19DFE1 VA: 0x19DEE0
	// RVA: 0x21BD1E0 Offset: 0x21BD2E1 VA: 0x21BD1E0
	public Quaternion get_OffsetRote() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DEF0 Offset: 0x19DFF1 VA: 0x19DEF0
	// RVA: 0x21BD1F0 Offset: 0x21BD2F1 VA: 0x21BD1F0
	public void set_OffsetRote(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF00 Offset: 0x19E001 VA: 0x19DF00
	// RVA: 0x21BD210 Offset: 0x21BD311 VA: 0x21BD210
	public Vector3 get_OffsetScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF10 Offset: 0x19E011 VA: 0x19DF10
	// RVA: 0x21BD220 Offset: 0x21BD321 VA: 0x21BD220
	public void set_OffsetScale(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF20 Offset: 0x19E021 VA: 0x19DF20
	// RVA: 0x21BD230 Offset: 0x21BD331 VA: 0x21BD230
	private Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF30 Offset: 0x19E031 VA: 0x19DF30
	// RVA: 0x21BD240 Offset: 0x21BD341 VA: 0x21BD240
	private void set_Velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF40 Offset: 0x19E041 VA: 0x19DF40
	// RVA: 0x21BD250 Offset: 0x21BD351 VA: 0x21BD250
	private Vector3 get_PrevPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF50 Offset: 0x19E051 VA: 0x19DF50
	// RVA: 0x21BD260 Offset: 0x21BD361 VA: 0x21BD260
	private void set_PrevPos(Vector3 value) { }

	// RVA: 0x21BD270 Offset: 0x21BD371 VA: 0x21BD270
	public void SetParentTransform(Transform transform) { }

	// RVA: 0x21BD650 Offset: 0x21BD751 VA: 0x21BD650
	public void Destroy() { }

	// RVA: 0x21BD6C0 Offset: 0x21BD7C1 VA: 0x21BD6C0
	private void OnDisable() { }

	// RVA: 0x21BD6E0 Offset: 0x21BD7E1 VA: 0x21BD6E0
	private void Awake() { }

	// RVA: 0x21BD740 Offset: 0x21BD841 VA: 0x21BD740
	private void Start() { }

	// RVA: 0x21BDAC0 Offset: 0x21BDBC1 VA: 0x21BDAC0
	private void WaitPlay_Enter() { }

	// RVA: 0x21BDAD0 Offset: 0x21BDBD1 VA: 0x21BDAD0
	private void WaitPlay_Update() { }

	// RVA: 0x21BDB60 Offset: 0x21BDC61 VA: 0x21BDB60
	private void WaitPlay_LateUpdate() { }

	// RVA: 0x21BDB70 Offset: 0x21BDC71 VA: 0x21BDB70
	private void LoopPlay_Enter() { }

	// RVA: 0x21BDB80 Offset: 0x21BDC81 VA: 0x21BDB80
	private void LoopPlay_Update() { }

	// RVA: 0x21BDC50 Offset: 0x21BDD51 VA: 0x21BDC50
	private void LoopPlay_LateUpdate() { }

	// RVA: 0x21BDC60 Offset: 0x21BDD61 VA: 0x21BDC60
	private void Playing_Enter() { }

	// RVA: 0x21BDC70 Offset: 0x21BDD71 VA: 0x21BDC70
	private void Playing_Update() { }

	// RVA: 0x21BDD50 Offset: 0x21BDE51 VA: 0x21BDD50
	private void Playing_LateUpdate() { }

	// RVA: 0x21BDD60 Offset: 0x21BDE61 VA: 0x21BDD60
	private void WaitDestroy_Enter() { }

	// RVA: 0x21BDDF0 Offset: 0x21BDEF1 VA: 0x21BDDF0
	private void WaitDestroy_Update() { }

	// RVA: 0x21BDE90 Offset: 0x21BDF91 VA: 0x21BDE90
	private void WaitDestroy_LateUpdate() { }

	// RVA: 0x21BD320 Offset: 0x21BD421 VA: 0x21BD320
	private void UpdateTransform() { }

	// RVA: 0x21BDF30 Offset: 0x21BE031 VA: 0x21BDF30
	private void UpdateTransformLocal(float deltaTime) { }

	// RVA: 0x21BD670 Offset: 0x21BD771 VA: 0x21BD670
	private bool ChangeState(ParticleDestroy.State state) { }

	// RVA: 0x21BE060 Offset: 0x21BE161 VA: 0x21BE060
	private void StateUpdate() { }

	// RVA: 0x21BE1D0 Offset: 0x21BE2D1 VA: 0x21BE1D0
	private void StateLateUpdate() { }

	// RVA: 0x21BE260 Offset: 0x21BE361 VA: 0x21BE260
	private void Update() { }

	// RVA: 0x21BE2F0 Offset: 0x21BE3F1 VA: 0x21BE2F0
	private void LateUpdate() { }

	// RVA: 0x21BE3D0 Offset: 0x21BE4D1 VA: 0x21BE3D0
	private void Reset() { }

	// RVA: 0x21BE410 Offset: 0x21BE511 VA: 0x21BE410
	public void .ctor() { }
}

