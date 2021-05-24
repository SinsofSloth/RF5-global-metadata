public class GandageCalcLotteryBossBehavior : CalcLotteryBossBehavior // TypeDefIndex: 10008
{
	// Fields
	private List<BossBehaviorParams> CurrentBehaviorParamsList; // 0x40

	// Methods

	// RVA: 0x22EBFF0 Offset: 0x22EC0F1 VA: 0x22EBFF0
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	// RVA: 0x22EC2C0 Offset: 0x22EC3C1 VA: 0x22EC2C0 Slot: 5
	public override void OnMadness() { }

	// RVA: 0x22EC340 Offset: 0x22EC441 VA: 0x22EC340
	private bool IsCheckState(int gandageListType) { }

	// RVA: 0x22EC370 Offset: 0x22EC471 VA: 0x22EC370
	private bool IsCheckStatePatternA(int gandageListType) { }

	// RVA: 0x22EC3A0 Offset: 0x22EC4A1 VA: 0x22EC3A0 Slot: 6
	public override int Lottery() { }

	// RVA: 0x22EC420 Offset: 0x22EC521 VA: 0x22EC420
	public int GetBehaviorType() { }

	// RVA: 0x22EC5D0 Offset: 0x22EC6D1 VA: 0x22EC5D0
	private void UpdateBehaviorList(int behaviorType) { }

	// RVA: 0x22EC580 Offset: 0x22EC681 VA: 0x22EC580
	private void UpdatePatternAFlag(int behaviorType) { }

	// RVA: 0x22EC680 Offset: 0x22EC781 VA: 0x22EC680 Slot: 8
	protected override void OnLoop() { }
}

