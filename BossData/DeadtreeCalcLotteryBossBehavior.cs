public class DeadtreeCalcLotteryBossBehavior : CalcLotteryBossBehavior // TypeDefIndex: 9993
{
	// Fields
	[SerializeField] // RVA: 0x180140 Offset: 0x180241 VA: 0x180140
	public List<DeadtreeBossDataAsset.LotteryParam> ActionList; // 0x40
	[SerializeField] // RVA: 0x180150 Offset: 0x180251 VA: 0x180150
	public List<DeadtreeBossDataAsset.LotteryParam> ExistBurrActionList; // 0x48
	[SerializeField] // RVA: 0x180160 Offset: 0x180261 VA: 0x180160
	public List<DeadtreeBossDataAsset.LotteryParam> MadnessActionList; // 0x50
	[SerializeField] // RVA: 0x180170 Offset: 0x180271 VA: 0x180170
	public List<DeadtreeBossDataAsset.LotteryParam> ExistBurrMadnessActionList; // 0x58
	[SerializeField] // RVA: 0x180180 Offset: 0x180281 VA: 0x180180
	public List<DeadtreeBossDataAsset.LotteryParam> DamageActionList; // 0x60

	// Methods

	// RVA: 0x22EB290 Offset: 0x22EB391 VA: 0x22EB290
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	// RVA: 0x22EB420 Offset: 0x22EB521 VA: 0x22EB420 Slot: 6
	public override int Lottery() { }

	// RVA: 0x22EB6D0 Offset: 0x22EB7D1 VA: 0x22EB6D0
	public List<DeadtreeBossDataAsset.LotteryParam> SelectAction() { }

	// RVA: 0x22EB740 Offset: 0x22EB841 VA: 0x22EB740 Slot: 9
	public override bool IsMovementAction(int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD700 Offset: 0x1AD801 VA: 0x1AD700
	// RVA: 0x22EB760 Offset: 0x22EB861 VA: 0x22EB760
	private bool <Lottery>b__7_1(DeadtreeBossDataAsset.LotteryParam x) { }
}

