public class HitSystem : MonoBehaviour // TypeDefIndex: 7621
{
	// Fields
	[SerializeField] // RVA: 0x168610 Offset: 0x168711 VA: 0x168610
	private string animationName; // 0x18
	[SerializeField] // RVA: 0x168620 Offset: 0x168721 VA: 0x168620
	private HitUnit[] HitUnitList; // 0x20
	[SerializeField] // RVA: 0x168630 Offset: 0x168731 VA: 0x168630
	public HitEffectUnit[] AttackEffects; // 0x28
	[SerializeField] // RVA: 0x168640 Offset: 0x168741 VA: 0x168640
	public HitMaster HitMaster; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x168650 Offset: 0x168751 VA: 0x168650
	private HashSet<CharacterBase>[] <HitChecks>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x168660 Offset: 0x168761 VA: 0x168660
	private bool <IsActive>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x168670 Offset: 0x168771 VA: 0x168670
	private float <CountTime>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x168680 Offset: 0x168781 VA: 0x168680
	private int <Index>k__BackingField; // 0x48
	private static HitSystem.UpdateVJ[] updateVJ; // 0x0

	// Properties
	private HashSet<CharacterBase>[] HitChecks { get; set; }
	public string AnimationName { get; }
	public bool IsActive { get; set; }
	public float CountTime { get; set; }
	public HitUnit[] HitUnits { get; }
	public int Index { get; set; }
	public float Speed { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A21C0 Offset: 0x1A22C1 VA: 0x1A21C0
	// RVA: 0x2305CD0 Offset: 0x2305DD1 VA: 0x2305CD0
	private HashSet<CharacterBase>[] get_HitChecks() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A21D0 Offset: 0x1A22D1 VA: 0x1A21D0
	// RVA: 0x2305CE0 Offset: 0x2305DE1 VA: 0x2305CE0
	private void set_HitChecks(HashSet<CharacterBase>[] value) { }

	// RVA: 0x2305CF0 Offset: 0x2305DF1 VA: 0x2305CF0
	public string get_AnimationName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A21E0 Offset: 0x1A22E1 VA: 0x1A21E0
	// RVA: 0x2305D00 Offset: 0x2305E01 VA: 0x2305D00
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A21F0 Offset: 0x1A22F1 VA: 0x1A21F0
	// RVA: 0x2305D10 Offset: 0x2305E11 VA: 0x2305D10
	private void set_IsActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2200 Offset: 0x1A2301 VA: 0x1A2200
	// RVA: 0x2305D20 Offset: 0x2305E21 VA: 0x2305D20
	public float get_CountTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2210 Offset: 0x1A2311 VA: 0x1A2210
	// RVA: 0x2305D30 Offset: 0x2305E31 VA: 0x2305D30
	private void set_CountTime(float value) { }

	// RVA: 0x2305D40 Offset: 0x2305E41 VA: 0x2305D40
	public HitUnit[] get_HitUnits() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2220 Offset: 0x1A2321 VA: 0x1A2220
	// RVA: 0x2305D50 Offset: 0x2305E51 VA: 0x2305D50
	public int get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2230 Offset: 0x1A2331 VA: 0x1A2230
	// RVA: 0x2305D60 Offset: 0x2305E61 VA: 0x2305D60
	public void set_Index(int value) { }

	// RVA: 0x2305D70 Offset: 0x2305E71 VA: 0x2305D70
	public float get_Speed() { }

	// RVA: 0x23042A0 Offset: 0x23043A1 VA: 0x23042A0
	public void HitStart(float scale) { }

	// RVA: 0x2304420 Offset: 0x2304521 VA: 0x2304420
	public void HitEnd() { }

	// RVA: 0x2303D00 Offset: 0x2303E01 VA: 0x2303D00
	public void HitUpdate(float deltaTime) { }

	// RVA: 0x2303F10 Offset: 0x2304011 VA: 0x2303F10
	public void HitTimeSync(float time) { }

	// RVA: 0x23062F0 Offset: 0x23063F1 VA: 0x23062F0
	private static bool UpdateEnd(HitUnit unit, float time) { }

	// RVA: 0x2306300 Offset: 0x2306401 VA: 0x2306300
	private static bool UpdateIdle(HitUnit unit, float time) { }

	// RVA: 0x2306400 Offset: 0x2306501 VA: 0x2306400
	private static bool UpdateHit(HitUnit unit, float time) { }

	// RVA: 0x2306520 Offset: 0x2306621 VA: 0x2306520
	public void OnHitTriggerEnter(HitUnit unit, Collider collider) { }

	// RVA: 0x23066F0 Offset: 0x23067F1 VA: 0x23066F0
	private void OnTriggerEnterEffect(HitUnit unit, Collider collider) { }

	// RVA: 0x2305E40 Offset: 0x2305F41 VA: 0x2305E40
	private void AttackEffectStart() { }

	// RVA: 0x2305EB0 Offset: 0x2305FB1 VA: 0x2305EB0
	private void AttackEffectEnd() { }

	// RVA: 0x2305F30 Offset: 0x2306031 VA: 0x2305F30
	private void AttackEffectUpdate(float time) { }

	// RVA: 0x2306B70 Offset: 0x2306C71 VA: 0x2306B70
	private void Awake() { }

	// RVA: 0x2306C70 Offset: 0x2306D71 VA: 0x2306C70
	public void .ctor() { }

	// RVA: 0x2306CE0 Offset: 0x2306DE1 VA: 0x2306CE0
	private static void .cctor() { }
}

