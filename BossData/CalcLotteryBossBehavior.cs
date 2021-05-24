public class CalcLotteryBossBehavior // TypeDefIndex: 9981
{
	// Fields
	protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FFD0 Offset: 0x1800D1 VA: 0x17FFD0
	private bool <IsMadness>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FFE0 Offset: 0x1800E1 VA: 0x17FFE0
	private int <NextBehaviorParamsIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17FFF0 Offset: 0x1800F1 VA: 0x17FFF0
	private int <LoopBehaviorParamsCounter>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180000 Offset: 0x180101 VA: 0x180000
	private float <TargetSqrDistance>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180010 Offset: 0x180111 VA: 0x180010
	private bool <IsHitPrevAttack>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180020 Offset: 0x180121 VA: 0x180020
	private int <RemainHp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x180030 Offset: 0x180131 VA: 0x180030
	private int <LotteryProbability>k__BackingField; // 0x30
	protected BitArray BitArray; // 0x38

	// Properties
	protected bool IsMadness { get; set; }
	public int NextBehaviorParamsIndex { get; set; }
	public int LoopBehaviorParamsCounter { get; set; }
	public float TargetSqrDistance { get; set; }
	public bool IsHitPrevAttack { get; set; }
	public int RemainHp { get; set; }
	private int LotteryProbability { get; set; }

	// Methods

	// RVA: 0x22E8E90 Offset: 0x22E8F91 VA: 0x22E8E90
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD610 Offset: 0x1AD711 VA: 0x1AD610
	// RVA: 0x22EA3B0 Offset: 0x22EA4B1 VA: 0x22EA3B0
	protected bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD620 Offset: 0x1AD721 VA: 0x1AD620
	// RVA: 0x22EA3C0 Offset: 0x22EA4C1 VA: 0x22EA3C0
	protected void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD630 Offset: 0x1AD731 VA: 0x1AD630
	// RVA: 0x22EA3D0 Offset: 0x22EA4D1 VA: 0x22EA3D0
	protected void set_NextBehaviorParamsIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD640 Offset: 0x1AD741 VA: 0x1AD640
	// RVA: 0x22EA3E0 Offset: 0x22EA4E1 VA: 0x22EA3E0
	public int get_NextBehaviorParamsIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD650 Offset: 0x1AD751 VA: 0x1AD650
	// RVA: 0x22EA3F0 Offset: 0x22EA4F1 VA: 0x22EA3F0
	private void set_LoopBehaviorParamsCounter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD660 Offset: 0x1AD761 VA: 0x1AD660
	// RVA: 0x22EA400 Offset: 0x22EA501 VA: 0x22EA400
	public int get_LoopBehaviorParamsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD670 Offset: 0x1AD771 VA: 0x1AD670
	// RVA: 0x22EA410 Offset: 0x22EA511 VA: 0x22EA410
	public void set_TargetSqrDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD680 Offset: 0x1AD781 VA: 0x1AD680
	// RVA: 0x22EA420 Offset: 0x22EA521 VA: 0x22EA420
	public float get_TargetSqrDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD690 Offset: 0x1AD791 VA: 0x1AD690
	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void set_IsHitPrevAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6A0 Offset: 0x1AD7A1 VA: 0x1AD6A0
	// RVA: 0x22EA440 Offset: 0x22EA541 VA: 0x22EA440
	public bool get_IsHitPrevAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6B0 Offset: 0x1AD7B1 VA: 0x1AD6B0
	// RVA: 0x22EA450 Offset: 0x22EA551 VA: 0x22EA450
	public void set_RemainHp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6C0 Offset: 0x1AD7C1 VA: 0x1AD6C0
	// RVA: 0x22EA460 Offset: 0x22EA561 VA: 0x22EA460
	public int get_RemainHp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6D0 Offset: 0x1AD7D1 VA: 0x1AD6D0
	// RVA: 0x22EA470 Offset: 0x22EA571 VA: 0x22EA470
	private void set_LotteryProbability(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6E0 Offset: 0x1AD7E1 VA: 0x1AD6E0
	// RVA: 0x22EA480 Offset: 0x22EA581 VA: 0x22EA480
	private int get_LotteryProbability() { }

	// RVA: 0x22EA490 Offset: 0x22EA591 VA: 0x22EA490 Slot: 4
	public virtual void Setup(int bitArraybits = 0) { }

	// RVA: 0x22E9FC0 Offset: 0x22EA0C1 VA: 0x22E9FC0 Slot: 5
	public virtual void OnMadness() { }

	// RVA: 0x22EA540 Offset: 0x22EA641 VA: 0x22EA540
	public void SetBitArray(int index, bool value) { }

	// RVA: 0x22EA570 Offset: 0x22EA671 VA: 0x22EA570
	public bool GetBitArray(int index) { }

	// RVA: 0x22E80C0 Offset: 0x22E81C1 VA: 0x22E80C0
	public void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E9380 Offset: 0x22E9481 VA: 0x22E9380 Slot: 6
	public virtual int Lottery() { }

	// RVA: 0x22EA120 Offset: 0x22EA221 VA: 0x22EA120
	protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList) { }

	// RVA: 0x22E9460 Offset: 0x22E9561 VA: 0x22E9460 Slot: 7
	protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam) { }

	// RVA: 0x22EA730 Offset: 0x22EA831 VA: 0x22EA730 Slot: 8
	protected virtual void OnLoop() { }

	// RVA: 0x22EA520 Offset: 0x22EA621 VA: 0x22EA520
	public void ResetNextBehaviorParamsIndex() { }

	// RVA: 0x22EA530 Offset: 0x22EA631 VA: 0x22EA530
	public void ResetLoopBehaviorParamsCounter() { }

	// RVA: 0x22EA740 Offset: 0x22EA841 VA: 0x22EA740 Slot: 9
	public virtual bool IsMovementAction(int type) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE690 Offset: 0x23BE791 VA: 0x23BE690
	|-CalcLotteryBossBehavior.Lottery<CerberusBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<DeadtreeBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<SkullDragonBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<Int32Enum>
	*/

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	private bool GetIsCompare(CompareType compareType, int param) { }

	// RVA: 0x22EA7C0 Offset: 0x22EA8C1 VA: 0x22EA7C0
	public bool IsMatchLoopCount(int value) { }

	// RVA: 0x22EA750 Offset: 0x22EA851 VA: 0x22EA750
	public bool IsLoopSurplusOddNumber() { }

	// RVA: 0x22EA770 Offset: 0x22EA871 VA: 0x22EA770
	public bool IsLoopSurplusEvenNumber() { }

	// RVA: 0x22EA780 Offset: 0x22EA881 VA: 0x22EA780
	public bool IsInTargetRange(int range) { }

	// RVA: 0x22EA7A0 Offset: 0x22EA8A1 VA: 0x22EA7A0
	public bool IsOutTargetRange(int range) { }

	// RVA: 0x22EA7D0 Offset: 0x22EA8D1 VA: 0x22EA7D0
	public bool IsRemainHp(int value) { }

	// RVA: 0x22EA7E0 Offset: 0x22EA8E1 VA: 0x22EA7E0
	public bool Probability(int value) { }
}

public class CalcLotteryBossBehavior // TypeDefIndex: 9981
{
	// Fields
	protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FFD0 Offset: 0x1800D1 VA: 0x17FFD0
	private bool <IsMadness>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FFE0 Offset: 0x1800E1 VA: 0x17FFE0
	private int <NextBehaviorParamsIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17FFF0 Offset: 0x1800F1 VA: 0x17FFF0
	private int <LoopBehaviorParamsCounter>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180000 Offset: 0x180101 VA: 0x180000
	private float <TargetSqrDistance>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180010 Offset: 0x180111 VA: 0x180010
	private bool <IsHitPrevAttack>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180020 Offset: 0x180121 VA: 0x180020
	private int <RemainHp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x180030 Offset: 0x180131 VA: 0x180030
	private int <LotteryProbability>k__BackingField; // 0x30
	protected BitArray BitArray; // 0x38

	// Properties
	protected bool IsMadness { get; set; }
	public int NextBehaviorParamsIndex { get; set; }
	public int LoopBehaviorParamsCounter { get; set; }
	public float TargetSqrDistance { get; set; }
	public bool IsHitPrevAttack { get; set; }
	public int RemainHp { get; set; }
	private int LotteryProbability { get; set; }

	// Methods

	// RVA: 0x22E8E90 Offset: 0x22E8F91 VA: 0x22E8E90
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD610 Offset: 0x1AD711 VA: 0x1AD610
	// RVA: 0x22EA3B0 Offset: 0x22EA4B1 VA: 0x22EA3B0
	protected bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD620 Offset: 0x1AD721 VA: 0x1AD620
	// RVA: 0x22EA3C0 Offset: 0x22EA4C1 VA: 0x22EA3C0
	protected void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD630 Offset: 0x1AD731 VA: 0x1AD630
	// RVA: 0x22EA3D0 Offset: 0x22EA4D1 VA: 0x22EA3D0
	protected void set_NextBehaviorParamsIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD640 Offset: 0x1AD741 VA: 0x1AD640
	// RVA: 0x22EA3E0 Offset: 0x22EA4E1 VA: 0x22EA3E0
	public int get_NextBehaviorParamsIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD650 Offset: 0x1AD751 VA: 0x1AD650
	// RVA: 0x22EA3F0 Offset: 0x22EA4F1 VA: 0x22EA3F0
	private void set_LoopBehaviorParamsCounter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD660 Offset: 0x1AD761 VA: 0x1AD660
	// RVA: 0x22EA400 Offset: 0x22EA501 VA: 0x22EA400
	public int get_LoopBehaviorParamsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD670 Offset: 0x1AD771 VA: 0x1AD670
	// RVA: 0x22EA410 Offset: 0x22EA511 VA: 0x22EA410
	public void set_TargetSqrDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD680 Offset: 0x1AD781 VA: 0x1AD680
	// RVA: 0x22EA420 Offset: 0x22EA521 VA: 0x22EA420
	public float get_TargetSqrDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD690 Offset: 0x1AD791 VA: 0x1AD690
	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void set_IsHitPrevAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6A0 Offset: 0x1AD7A1 VA: 0x1AD6A0
	// RVA: 0x22EA440 Offset: 0x22EA541 VA: 0x22EA440
	public bool get_IsHitPrevAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6B0 Offset: 0x1AD7B1 VA: 0x1AD6B0
	// RVA: 0x22EA450 Offset: 0x22EA551 VA: 0x22EA450
	public void set_RemainHp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6C0 Offset: 0x1AD7C1 VA: 0x1AD6C0
	// RVA: 0x22EA460 Offset: 0x22EA561 VA: 0x22EA460
	public int get_RemainHp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6D0 Offset: 0x1AD7D1 VA: 0x1AD6D0
	// RVA: 0x22EA470 Offset: 0x22EA571 VA: 0x22EA470
	private void set_LotteryProbability(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6E0 Offset: 0x1AD7E1 VA: 0x1AD6E0
	// RVA: 0x22EA480 Offset: 0x22EA581 VA: 0x22EA480
	private int get_LotteryProbability() { }

	// RVA: 0x22EA490 Offset: 0x22EA591 VA: 0x22EA490 Slot: 4
	public virtual void Setup(int bitArraybits = 0) { }

	// RVA: 0x22E9FC0 Offset: 0x22EA0C1 VA: 0x22E9FC0 Slot: 5
	public virtual void OnMadness() { }

	// RVA: 0x22EA540 Offset: 0x22EA641 VA: 0x22EA540
	public void SetBitArray(int index, bool value) { }

	// RVA: 0x22EA570 Offset: 0x22EA671 VA: 0x22EA570
	public bool GetBitArray(int index) { }

	// RVA: 0x22E80C0 Offset: 0x22E81C1 VA: 0x22E80C0
	public void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E9380 Offset: 0x22E9481 VA: 0x22E9380 Slot: 6
	public virtual int Lottery() { }

	// RVA: 0x22EA120 Offset: 0x22EA221 VA: 0x22EA120
	protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList) { }

	// RVA: 0x22E9460 Offset: 0x22E9561 VA: 0x22E9460 Slot: 7
	protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam) { }

	// RVA: 0x22EA730 Offset: 0x22EA831 VA: 0x22EA730 Slot: 8
	protected virtual void OnLoop() { }

	// RVA: 0x22EA520 Offset: 0x22EA621 VA: 0x22EA520
	public void ResetNextBehaviorParamsIndex() { }

	// RVA: 0x22EA530 Offset: 0x22EA631 VA: 0x22EA530
	public void ResetLoopBehaviorParamsCounter() { }

	// RVA: 0x22EA740 Offset: 0x22EA841 VA: 0x22EA740 Slot: 9
	public virtual bool IsMovementAction(int type) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE690 Offset: 0x23BE791 VA: 0x23BE690
	|-CalcLotteryBossBehavior.Lottery<CerberusBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<DeadtreeBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<SkullDragonBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<Int32Enum>
	*/

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	private bool GetIsCompare(CompareType compareType, int param) { }

	// RVA: 0x22EA7C0 Offset: 0x22EA8C1 VA: 0x22EA7C0
	public bool IsMatchLoopCount(int value) { }

	// RVA: 0x22EA750 Offset: 0x22EA851 VA: 0x22EA750
	public bool IsLoopSurplusOddNumber() { }

	// RVA: 0x22EA770 Offset: 0x22EA871 VA: 0x22EA770
	public bool IsLoopSurplusEvenNumber() { }

	// RVA: 0x22EA780 Offset: 0x22EA881 VA: 0x22EA780
	public bool IsInTargetRange(int range) { }

	// RVA: 0x22EA7A0 Offset: 0x22EA8A1 VA: 0x22EA7A0
	public bool IsOutTargetRange(int range) { }

	// RVA: 0x22EA7D0 Offset: 0x22EA8D1 VA: 0x22EA7D0
	public bool IsRemainHp(int value) { }

	// RVA: 0x22EA7E0 Offset: 0x22EA8E1 VA: 0x22EA7E0
	public bool Probability(int value) { }
}

public class CalcLotteryBossBehavior // TypeDefIndex: 9981
{
	// Fields
	protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FFD0 Offset: 0x1800D1 VA: 0x17FFD0
	private bool <IsMadness>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FFE0 Offset: 0x1800E1 VA: 0x17FFE0
	private int <NextBehaviorParamsIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17FFF0 Offset: 0x1800F1 VA: 0x17FFF0
	private int <LoopBehaviorParamsCounter>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180000 Offset: 0x180101 VA: 0x180000
	private float <TargetSqrDistance>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180010 Offset: 0x180111 VA: 0x180010
	private bool <IsHitPrevAttack>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180020 Offset: 0x180121 VA: 0x180020
	private int <RemainHp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x180030 Offset: 0x180131 VA: 0x180030
	private int <LotteryProbability>k__BackingField; // 0x30
	protected BitArray BitArray; // 0x38

	// Properties
	protected bool IsMadness { get; set; }
	public int NextBehaviorParamsIndex { get; set; }
	public int LoopBehaviorParamsCounter { get; set; }
	public float TargetSqrDistance { get; set; }
	public bool IsHitPrevAttack { get; set; }
	public int RemainHp { get; set; }
	private int LotteryProbability { get; set; }

	// Methods

	// RVA: 0x22E8E90 Offset: 0x22E8F91 VA: 0x22E8E90
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD610 Offset: 0x1AD711 VA: 0x1AD610
	// RVA: 0x22EA3B0 Offset: 0x22EA4B1 VA: 0x22EA3B0
	protected bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD620 Offset: 0x1AD721 VA: 0x1AD620
	// RVA: 0x22EA3C0 Offset: 0x22EA4C1 VA: 0x22EA3C0
	protected void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD630 Offset: 0x1AD731 VA: 0x1AD630
	// RVA: 0x22EA3D0 Offset: 0x22EA4D1 VA: 0x22EA3D0
	protected void set_NextBehaviorParamsIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD640 Offset: 0x1AD741 VA: 0x1AD640
	// RVA: 0x22EA3E0 Offset: 0x22EA4E1 VA: 0x22EA3E0
	public int get_NextBehaviorParamsIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD650 Offset: 0x1AD751 VA: 0x1AD650
	// RVA: 0x22EA3F0 Offset: 0x22EA4F1 VA: 0x22EA3F0
	private void set_LoopBehaviorParamsCounter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD660 Offset: 0x1AD761 VA: 0x1AD660
	// RVA: 0x22EA400 Offset: 0x22EA501 VA: 0x22EA400
	public int get_LoopBehaviorParamsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD670 Offset: 0x1AD771 VA: 0x1AD670
	// RVA: 0x22EA410 Offset: 0x22EA511 VA: 0x22EA410
	public void set_TargetSqrDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD680 Offset: 0x1AD781 VA: 0x1AD680
	// RVA: 0x22EA420 Offset: 0x22EA521 VA: 0x22EA420
	public float get_TargetSqrDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD690 Offset: 0x1AD791 VA: 0x1AD690
	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void set_IsHitPrevAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6A0 Offset: 0x1AD7A1 VA: 0x1AD6A0
	// RVA: 0x22EA440 Offset: 0x22EA541 VA: 0x22EA440
	public bool get_IsHitPrevAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6B0 Offset: 0x1AD7B1 VA: 0x1AD6B0
	// RVA: 0x22EA450 Offset: 0x22EA551 VA: 0x22EA450
	public void set_RemainHp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6C0 Offset: 0x1AD7C1 VA: 0x1AD6C0
	// RVA: 0x22EA460 Offset: 0x22EA561 VA: 0x22EA460
	public int get_RemainHp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6D0 Offset: 0x1AD7D1 VA: 0x1AD6D0
	// RVA: 0x22EA470 Offset: 0x22EA571 VA: 0x22EA470
	private void set_LotteryProbability(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6E0 Offset: 0x1AD7E1 VA: 0x1AD6E0
	// RVA: 0x22EA480 Offset: 0x22EA581 VA: 0x22EA480
	private int get_LotteryProbability() { }

	// RVA: 0x22EA490 Offset: 0x22EA591 VA: 0x22EA490 Slot: 4
	public virtual void Setup(int bitArraybits = 0) { }

	// RVA: 0x22E9FC0 Offset: 0x22EA0C1 VA: 0x22E9FC0 Slot: 5
	public virtual void OnMadness() { }

	// RVA: 0x22EA540 Offset: 0x22EA641 VA: 0x22EA540
	public void SetBitArray(int index, bool value) { }

	// RVA: 0x22EA570 Offset: 0x22EA671 VA: 0x22EA570
	public bool GetBitArray(int index) { }

	// RVA: 0x22E80C0 Offset: 0x22E81C1 VA: 0x22E80C0
	public void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E9380 Offset: 0x22E9481 VA: 0x22E9380 Slot: 6
	public virtual int Lottery() { }

	// RVA: 0x22EA120 Offset: 0x22EA221 VA: 0x22EA120
	protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList) { }

	// RVA: 0x22E9460 Offset: 0x22E9561 VA: 0x22E9460 Slot: 7
	protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam) { }

	// RVA: 0x22EA730 Offset: 0x22EA831 VA: 0x22EA730 Slot: 8
	protected virtual void OnLoop() { }

	// RVA: 0x22EA520 Offset: 0x22EA621 VA: 0x22EA520
	public void ResetNextBehaviorParamsIndex() { }

	// RVA: 0x22EA530 Offset: 0x22EA631 VA: 0x22EA530
	public void ResetLoopBehaviorParamsCounter() { }

	// RVA: 0x22EA740 Offset: 0x22EA841 VA: 0x22EA740 Slot: 9
	public virtual bool IsMovementAction(int type) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE690 Offset: 0x23BE791 VA: 0x23BE690
	|-CalcLotteryBossBehavior.Lottery<CerberusBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<DeadtreeBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<SkullDragonBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<Int32Enum>
	*/

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	private bool GetIsCompare(CompareType compareType, int param) { }

	// RVA: 0x22EA7C0 Offset: 0x22EA8C1 VA: 0x22EA7C0
	public bool IsMatchLoopCount(int value) { }

	// RVA: 0x22EA750 Offset: 0x22EA851 VA: 0x22EA750
	public bool IsLoopSurplusOddNumber() { }

	// RVA: 0x22EA770 Offset: 0x22EA871 VA: 0x22EA770
	public bool IsLoopSurplusEvenNumber() { }

	// RVA: 0x22EA780 Offset: 0x22EA881 VA: 0x22EA780
	public bool IsInTargetRange(int range) { }

	// RVA: 0x22EA7A0 Offset: 0x22EA8A1 VA: 0x22EA7A0
	public bool IsOutTargetRange(int range) { }

	// RVA: 0x22EA7D0 Offset: 0x22EA8D1 VA: 0x22EA7D0
	public bool IsRemainHp(int value) { }

	// RVA: 0x22EA7E0 Offset: 0x22EA8E1 VA: 0x22EA7E0
	public bool Probability(int value) { }
}

public class CalcLotteryBossBehavior // TypeDefIndex: 9981
{
	// Fields
	protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FFD0 Offset: 0x1800D1 VA: 0x17FFD0
	private bool <IsMadness>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FFE0 Offset: 0x1800E1 VA: 0x17FFE0
	private int <NextBehaviorParamsIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17FFF0 Offset: 0x1800F1 VA: 0x17FFF0
	private int <LoopBehaviorParamsCounter>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180000 Offset: 0x180101 VA: 0x180000
	private float <TargetSqrDistance>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180010 Offset: 0x180111 VA: 0x180010
	private bool <IsHitPrevAttack>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180020 Offset: 0x180121 VA: 0x180020
	private int <RemainHp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x180030 Offset: 0x180131 VA: 0x180030
	private int <LotteryProbability>k__BackingField; // 0x30
	protected BitArray BitArray; // 0x38

	// Properties
	protected bool IsMadness { get; set; }
	public int NextBehaviorParamsIndex { get; set; }
	public int LoopBehaviorParamsCounter { get; set; }
	public float TargetSqrDistance { get; set; }
	public bool IsHitPrevAttack { get; set; }
	public int RemainHp { get; set; }
	private int LotteryProbability { get; set; }

	// Methods

	// RVA: 0x22E8E90 Offset: 0x22E8F91 VA: 0x22E8E90
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD610 Offset: 0x1AD711 VA: 0x1AD610
	// RVA: 0x22EA3B0 Offset: 0x22EA4B1 VA: 0x22EA3B0
	protected bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD620 Offset: 0x1AD721 VA: 0x1AD620
	// RVA: 0x22EA3C0 Offset: 0x22EA4C1 VA: 0x22EA3C0
	protected void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD630 Offset: 0x1AD731 VA: 0x1AD630
	// RVA: 0x22EA3D0 Offset: 0x22EA4D1 VA: 0x22EA3D0
	protected void set_NextBehaviorParamsIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD640 Offset: 0x1AD741 VA: 0x1AD640
	// RVA: 0x22EA3E0 Offset: 0x22EA4E1 VA: 0x22EA3E0
	public int get_NextBehaviorParamsIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD650 Offset: 0x1AD751 VA: 0x1AD650
	// RVA: 0x22EA3F0 Offset: 0x22EA4F1 VA: 0x22EA3F0
	private void set_LoopBehaviorParamsCounter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD660 Offset: 0x1AD761 VA: 0x1AD660
	// RVA: 0x22EA400 Offset: 0x22EA501 VA: 0x22EA400
	public int get_LoopBehaviorParamsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD670 Offset: 0x1AD771 VA: 0x1AD670
	// RVA: 0x22EA410 Offset: 0x22EA511 VA: 0x22EA410
	public void set_TargetSqrDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD680 Offset: 0x1AD781 VA: 0x1AD680
	// RVA: 0x22EA420 Offset: 0x22EA521 VA: 0x22EA420
	public float get_TargetSqrDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD690 Offset: 0x1AD791 VA: 0x1AD690
	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void set_IsHitPrevAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6A0 Offset: 0x1AD7A1 VA: 0x1AD6A0
	// RVA: 0x22EA440 Offset: 0x22EA541 VA: 0x22EA440
	public bool get_IsHitPrevAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6B0 Offset: 0x1AD7B1 VA: 0x1AD6B0
	// RVA: 0x22EA450 Offset: 0x22EA551 VA: 0x22EA450
	public void set_RemainHp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6C0 Offset: 0x1AD7C1 VA: 0x1AD6C0
	// RVA: 0x22EA460 Offset: 0x22EA561 VA: 0x22EA460
	public int get_RemainHp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6D0 Offset: 0x1AD7D1 VA: 0x1AD6D0
	// RVA: 0x22EA470 Offset: 0x22EA571 VA: 0x22EA470
	private void set_LotteryProbability(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6E0 Offset: 0x1AD7E1 VA: 0x1AD6E0
	// RVA: 0x22EA480 Offset: 0x22EA581 VA: 0x22EA480
	private int get_LotteryProbability() { }

	// RVA: 0x22EA490 Offset: 0x22EA591 VA: 0x22EA490 Slot: 4
	public virtual void Setup(int bitArraybits = 0) { }

	// RVA: 0x22E9FC0 Offset: 0x22EA0C1 VA: 0x22E9FC0 Slot: 5
	public virtual void OnMadness() { }

	// RVA: 0x22EA540 Offset: 0x22EA641 VA: 0x22EA540
	public void SetBitArray(int index, bool value) { }

	// RVA: 0x22EA570 Offset: 0x22EA671 VA: 0x22EA570
	public bool GetBitArray(int index) { }

	// RVA: 0x22E80C0 Offset: 0x22E81C1 VA: 0x22E80C0
	public void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E9380 Offset: 0x22E9481 VA: 0x22E9380 Slot: 6
	public virtual int Lottery() { }

	// RVA: 0x22EA120 Offset: 0x22EA221 VA: 0x22EA120
	protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList) { }

	// RVA: 0x22E9460 Offset: 0x22E9561 VA: 0x22E9460 Slot: 7
	protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam) { }

	// RVA: 0x22EA730 Offset: 0x22EA831 VA: 0x22EA730 Slot: 8
	protected virtual void OnLoop() { }

	// RVA: 0x22EA520 Offset: 0x22EA621 VA: 0x22EA520
	public void ResetNextBehaviorParamsIndex() { }

	// RVA: 0x22EA530 Offset: 0x22EA631 VA: 0x22EA530
	public void ResetLoopBehaviorParamsCounter() { }

	// RVA: 0x22EA740 Offset: 0x22EA841 VA: 0x22EA740 Slot: 9
	public virtual bool IsMovementAction(int type) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE690 Offset: 0x23BE791 VA: 0x23BE690
	|-CalcLotteryBossBehavior.Lottery<CerberusBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<DeadtreeBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<SkullDragonBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<Int32Enum>
	*/

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	private bool GetIsCompare(CompareType compareType, int param) { }

	// RVA: 0x22EA7C0 Offset: 0x22EA8C1 VA: 0x22EA7C0
	public bool IsMatchLoopCount(int value) { }

	// RVA: 0x22EA750 Offset: 0x22EA851 VA: 0x22EA750
	public bool IsLoopSurplusOddNumber() { }

	// RVA: 0x22EA770 Offset: 0x22EA871 VA: 0x22EA770
	public bool IsLoopSurplusEvenNumber() { }

	// RVA: 0x22EA780 Offset: 0x22EA881 VA: 0x22EA780
	public bool IsInTargetRange(int range) { }

	// RVA: 0x22EA7A0 Offset: 0x22EA8A1 VA: 0x22EA7A0
	public bool IsOutTargetRange(int range) { }

	// RVA: 0x22EA7D0 Offset: 0x22EA8D1 VA: 0x22EA7D0
	public bool IsRemainHp(int value) { }

	// RVA: 0x22EA7E0 Offset: 0x22EA8E1 VA: 0x22EA7E0
	public bool Probability(int value) { }
}

public class CalcLotteryBossBehavior // TypeDefIndex: 9981
{
	// Fields
	protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FFD0 Offset: 0x1800D1 VA: 0x17FFD0
	private bool <IsMadness>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FFE0 Offset: 0x1800E1 VA: 0x17FFE0
	private int <NextBehaviorParamsIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17FFF0 Offset: 0x1800F1 VA: 0x17FFF0
	private int <LoopBehaviorParamsCounter>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180000 Offset: 0x180101 VA: 0x180000
	private float <TargetSqrDistance>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180010 Offset: 0x180111 VA: 0x180010
	private bool <IsHitPrevAttack>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180020 Offset: 0x180121 VA: 0x180020
	private int <RemainHp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x180030 Offset: 0x180131 VA: 0x180030
	private int <LotteryProbability>k__BackingField; // 0x30
	protected BitArray BitArray; // 0x38

	// Properties
	protected bool IsMadness { get; set; }
	public int NextBehaviorParamsIndex { get; set; }
	public int LoopBehaviorParamsCounter { get; set; }
	public float TargetSqrDistance { get; set; }
	public bool IsHitPrevAttack { get; set; }
	public int RemainHp { get; set; }
	private int LotteryProbability { get; set; }

	// Methods

	// RVA: 0x22E8E90 Offset: 0x22E8F91 VA: 0x22E8E90
	public void .ctor(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD610 Offset: 0x1AD711 VA: 0x1AD610
	// RVA: 0x22EA3B0 Offset: 0x22EA4B1 VA: 0x22EA3B0
	protected bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD620 Offset: 0x1AD721 VA: 0x1AD620
	// RVA: 0x22EA3C0 Offset: 0x22EA4C1 VA: 0x22EA3C0
	protected void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD630 Offset: 0x1AD731 VA: 0x1AD630
	// RVA: 0x22EA3D0 Offset: 0x22EA4D1 VA: 0x22EA3D0
	protected void set_NextBehaviorParamsIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD640 Offset: 0x1AD741 VA: 0x1AD640
	// RVA: 0x22EA3E0 Offset: 0x22EA4E1 VA: 0x22EA3E0
	public int get_NextBehaviorParamsIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD650 Offset: 0x1AD751 VA: 0x1AD650
	// RVA: 0x22EA3F0 Offset: 0x22EA4F1 VA: 0x22EA3F0
	private void set_LoopBehaviorParamsCounter(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD660 Offset: 0x1AD761 VA: 0x1AD660
	// RVA: 0x22EA400 Offset: 0x22EA501 VA: 0x22EA400
	public int get_LoopBehaviorParamsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD670 Offset: 0x1AD771 VA: 0x1AD670
	// RVA: 0x22EA410 Offset: 0x22EA511 VA: 0x22EA410
	public void set_TargetSqrDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD680 Offset: 0x1AD781 VA: 0x1AD680
	// RVA: 0x22EA420 Offset: 0x22EA521 VA: 0x22EA420
	public float get_TargetSqrDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD690 Offset: 0x1AD791 VA: 0x1AD690
	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void set_IsHitPrevAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6A0 Offset: 0x1AD7A1 VA: 0x1AD6A0
	// RVA: 0x22EA440 Offset: 0x22EA541 VA: 0x22EA440
	public bool get_IsHitPrevAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6B0 Offset: 0x1AD7B1 VA: 0x1AD6B0
	// RVA: 0x22EA450 Offset: 0x22EA551 VA: 0x22EA450
	public void set_RemainHp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6C0 Offset: 0x1AD7C1 VA: 0x1AD6C0
	// RVA: 0x22EA460 Offset: 0x22EA561 VA: 0x22EA460
	public int get_RemainHp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6D0 Offset: 0x1AD7D1 VA: 0x1AD6D0
	// RVA: 0x22EA470 Offset: 0x22EA571 VA: 0x22EA470
	private void set_LotteryProbability(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD6E0 Offset: 0x1AD7E1 VA: 0x1AD6E0
	// RVA: 0x22EA480 Offset: 0x22EA581 VA: 0x22EA480
	private int get_LotteryProbability() { }

	// RVA: 0x22EA490 Offset: 0x22EA591 VA: 0x22EA490 Slot: 4
	public virtual void Setup(int bitArraybits = 0) { }

	// RVA: 0x22E9FC0 Offset: 0x22EA0C1 VA: 0x22E9FC0 Slot: 5
	public virtual void OnMadness() { }

	// RVA: 0x22EA540 Offset: 0x22EA641 VA: 0x22EA540
	public void SetBitArray(int index, bool value) { }

	// RVA: 0x22EA570 Offset: 0x22EA671 VA: 0x22EA570
	public bool GetBitArray(int index) { }

	// RVA: 0x22E80C0 Offset: 0x22E81C1 VA: 0x22E80C0
	public void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E9380 Offset: 0x22E9481 VA: 0x22E9380 Slot: 6
	public virtual int Lottery() { }

	// RVA: 0x22EA120 Offset: 0x22EA221 VA: 0x22EA120
	protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList) { }

	// RVA: 0x22E9460 Offset: 0x22E9561 VA: 0x22E9460 Slot: 7
	protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam) { }

	// RVA: 0x22EA730 Offset: 0x22EA831 VA: 0x22EA730 Slot: 8
	protected virtual void OnLoop() { }

	// RVA: 0x22EA520 Offset: 0x22EA621 VA: 0x22EA520
	public void ResetNextBehaviorParamsIndex() { }

	// RVA: 0x22EA530 Offset: 0x22EA631 VA: 0x22EA530
	public void ResetLoopBehaviorParamsCounter() { }

	// RVA: 0x22EA740 Offset: 0x22EA841 VA: 0x22EA740 Slot: 9
	public virtual bool IsMovementAction(int type) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE690 Offset: 0x23BE791 VA: 0x23BE690
	|-CalcLotteryBossBehavior.Lottery<CerberusBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<DeadtreeBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<SkullDragonBossDataAsset.LotteryType>
	|-CalcLotteryBossBehavior.Lottery<Int32Enum>
	*/

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	private bool GetIsCompare(CompareType compareType, int param) { }

	// RVA: 0x22EA7C0 Offset: 0x22EA8C1 VA: 0x22EA7C0
	public bool IsMatchLoopCount(int value) { }

	// RVA: 0x22EA750 Offset: 0x22EA851 VA: 0x22EA750
	public bool IsLoopSurplusOddNumber() { }

	// RVA: 0x22EA770 Offset: 0x22EA871 VA: 0x22EA770
	public bool IsLoopSurplusEvenNumber() { }

	// RVA: 0x22EA780 Offset: 0x22EA881 VA: 0x22EA780
	public bool IsInTargetRange(int range) { }

	// RVA: 0x22EA7A0 Offset: 0x22EA8A1 VA: 0x22EA7A0
	public bool IsOutTargetRange(int range) { }

	// RVA: 0x22EA7D0 Offset: 0x22EA8D1 VA: 0x22EA7D0
	public bool IsRemainHp(int value) { }

	// RVA: 0x22EA7E0 Offset: 0x22EA8E1 VA: 0x22EA7E0
	public bool Probability(int value) { }
}

