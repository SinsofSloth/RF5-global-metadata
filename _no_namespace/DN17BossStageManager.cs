public class DN17BossStageManager : BossStageManager, DN17BossStageInterface // TypeDefIndex: 7732
{
	// Fields
	private GameObject GlassStage; // 0xA8
	private GameObject CrackGlassStage; // 0xB0
	private GameObject CrackGlassCollider; // 0xB8
	[SerializeField] // RVA: 0x168FC0 Offset: 0x1690C1 VA: 0x168FC0
	private GameObject GlassStageNavmeshSurface; // 0xC0
	[SerializeField] // RVA: 0x168FD0 Offset: 0x1690D1 VA: 0x168FD0
	private GameObject CrackGlassStageNavmeshSurface; // 0xC8
	[SerializeField] // RVA: 0x168FE0 Offset: 0x1690E1 VA: 0x168FE0
	private Transform ApeearMadnessBoss; // 0xD0
	private GandageBehaviorController GandageBehaviorController; // 0xD8

	// Methods

	// RVA: 0x1CA7770 Offset: 0x1CA7871 VA: 0x1CA7770 Slot: 5
	protected override void OnSetup() { }

	// RVA: 0x1CA78D0 Offset: 0x1CA79D1 VA: 0x1CA78D0
	public void CrackStage(bool isCrack) { }

	// RVA: 0x1CA7980 Offset: 0x1CA7A81 VA: 0x1CA7980 Slot: 8
	public void CrackStage() { }

	// RVA: 0x1CA7BF0 Offset: 0x1CA7CF1 VA: 0x1CA7BF0 Slot: 6
	protected override void OnBeforeCreateBoss() { }

	// RVA: 0x1CA7C00 Offset: 0x1CA7D01 VA: 0x1CA7C00 Slot: 7
	protected override void OnAfterCreateBoss(BossBehaviorController controller) { }

	// RVA: 0x1CA7CF0 Offset: 0x1CA7DF1 VA: 0x1CA7CF0
	public void .ctor() { }
}

