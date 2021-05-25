public class SkullDragonCalcLotteryBossBehavior : CalcLotteryBossBehavior // TypeDefIndex: 10104
{
	// Fields
	[SerializeField] // RVA: 0x180750 Offset: 0x180851 VA: 0x180750
	public List<SkullDragonBossDataAsset.LotteryParam> ActionList; // 0x40
	[SerializeField] // RVA: 0x180760 Offset: 0x180861 VA: 0x180760
	public List<SkullDragonBossDataAsset.LotteryParam> FilledTailDamageActionList; // 0x48
	[SerializeField] // RVA: 0x180770 Offset: 0x180871 VA: 0x180770
	public List<SkullDragonBossDataAsset.LotteryParam> MadnessActionList; // 0x50

	// Methods

	// RVA: 0x205AED0 Offset: 0x205AFD1 VA: 0x205AED0
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	// RVA: 0x205AF40 Offset: 0x205B041 VA: 0x205AF40 Slot: 6
	public override int Lottery() { }

	// RVA: 0x205B190 Offset: 0x205B291 VA: 0x205B190 Slot: 9
	public override bool IsMovementAction(int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD730 Offset: 0x1AD831 VA: 0x1AD730
	// RVA: 0x205B1B0 Offset: 0x205B2B1 VA: 0x205B1B0
	private bool <Lottery>b__5_1(SkullDragonBossDataAsset.LotteryParam x) { }
}

