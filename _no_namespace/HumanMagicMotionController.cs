public class HumanMagicMotionController : CharaMagicMotionController<HumanController, HumanMagicMotionType> // TypeDefIndex: 6658
{
	// Fields
	private static Dictionary<HumanMagicMotionType, HumanMagicMotionController.HumanMagicMotion> m_MotionDataTable; // 0x0
	private HumanMagicMotionType m_CurrentMotionType; // 0x20
	private MagicID m_MagicID; // 0x24
	private int m_MagicLevel; // 0x28
	private AttackAttribute m_AttackAttribute; // 0x2C

	// Properties
	public override bool IsPlaying { get; }

	// Methods

	// RVA: 0x20BCEE0 Offset: 0x20BCFE1 VA: 0x20BCEE0 Slot: 4
	public override bool get_IsPlaying() { }

	// RVA: 0x20BCEF0 Offset: 0x20BCFF1 VA: 0x20BCEF0 Slot: 6
	public override bool DoPlay(int no, MagicID magicId, int level) { }

	// RVA: 0x20BCF00 Offset: 0x20BD001 VA: 0x20BCF00 Slot: 11
	public override bool DoPlay(HumanMagicMotionType motionType, MagicID magicId, int level) { }

	// RVA: 0x20BD1B0 Offset: 0x20BD2B1 VA: 0x20BD1B0 Slot: 7
	public override void DoStop() { }

	// RVA: 0x20BD1E0 Offset: 0x20BD2E1 VA: 0x20BD1E0 Slot: 8
	public override void DoCancel() { }

	// RVA: 0x20BD210 Offset: 0x20BD311 VA: 0x20BD210 Slot: 9
	public override bool DoShot(float rpRate) { }

	// RVA: 0x20BD350 Offset: 0x20BD451 VA: 0x20BD350
	public void .ctor() { }

	// RVA: 0x20BD3B0 Offset: 0x20BD4B1 VA: 0x20BD3B0
	private static void .cctor() { }
}

