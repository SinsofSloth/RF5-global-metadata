public abstract class CharacterStatusBase : StatusBase // TypeDefIndex: 8293
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16E9B0 Offset: 0x16EAB1 VA: 0x16E9B0
	private StatusDataBase <StatusData>k__BackingField; // 0xF0
	protected Coroutine Coroutine; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x16E9C0 Offset: 0x16EAC1 VA: 0x16E9C0
	private TimeManager.JustTimerData <TemporaryStatus_UseItem_Handle>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x16E9D0 Offset: 0x16EAD1 VA: 0x16E9D0
	private int <TemporaryStatus_HotSpring_End_Time>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x16E9E0 Offset: 0x16EAE1 VA: 0x16E9E0
	private TimeManager.JustTimerData <TemporaryStatus_HotSpring_Handle>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x16E9F0 Offset: 0x16EAF1 VA: 0x16E9F0
	private int <TemporaryStatus_Vaccination_End_Time>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x16EA00 Offset: 0x16EB01 VA: 0x16EA00
	private TimeManager.JustTimerData <TemporaryStatus_Vaccination_Handle>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x16EA10 Offset: 0x16EB11 VA: 0x16EA10
	private int <Score_ATKUp_End_Time>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x16EA20 Offset: 0x16EB21 VA: 0x16EA20
	private TimeManager.JustTimerData <Score_ATKUp_Handle>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x16EA30 Offset: 0x16EB31 VA: 0x16EA30
	private int <Score_DEFUp_End_Time>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x16EA40 Offset: 0x16EB41 VA: 0x16EA40
	private TimeManager.JustTimerData <Score_DEFUp_Handle>k__BackingField; // 0x140
	public OnUpdateStatusEvent OnUpdateStatus; // 0x148
	public OnUpdateStatusEvent OnUpdateHp; // 0x150
	public OnUpdateStatusEvent OnUpdateRp; // 0x158
	public OnWinceEvent OnWince; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x16EA50 Offset: 0x16EB51 VA: 0x16EA50
	private float <StunGage>k__BackingField; // 0x168
	private const float REGENE_TIMER = 2.1166666;
	private float HpHealTimer; // 0x16C
	private float RpHealTimer; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x16EA60 Offset: 0x16EB61 VA: 0x16EA60
	private float <PoisonTimer>k__BackingField; // 0x174
	[CompilerGeneratedAttribute] // RVA: 0x16EA70 Offset: 0x16EB71 VA: 0x16EA70
	private float <SickTimer>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x16EA80 Offset: 0x16EB81 VA: 0x16EA80
	private float <StunTimer>k__BackingField; // 0x17C
	[CompilerGeneratedAttribute] // RVA: 0x16EA90 Offset: 0x16EB91 VA: 0x16EA90
	private float <SleepTimer>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x16EAA0 Offset: 0x16EBA1 VA: 0x16EAA0
	private float <CurrentKnockbackTimer>k__BackingField; // 0x184
	[CompilerGeneratedAttribute] // RVA: 0x16EAB0 Offset: 0x16EBB1 VA: 0x16EAB0
	private float <BlowHealCoolTime>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x16EAC0 Offset: 0x16EBC1 VA: 0x16EAC0
	private float <CurrentBlowTimer>k__BackingField; // 0x18C
	public HUDBadStatusIconDisp HUDBadStatusIconDisp; // 0x190
	private DamageInfo PoisonDamageInfo; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x16EAD0 Offset: 0x16EBD1 VA: 0x16EAD0
	private bool <IsInvisible>k__BackingField; // 0x218

	// Properties
	public StatusDataBase StatusData { get; set; }
	protected virtual bool IsBoss { get; }
	public int Level { get; set; }
	public int Exp { get; set; }
	public override int Hp { get; set; }
	public ItemData TemporaryStatus_UseItem { get; set; }
	public int TemporaryStatus_UseItem_Time { get; set; }
	protected TimeManager.JustTimerData TemporaryStatus_UseItem_Handle { get; set; }
	public HotSpringID TemporaryStatus_HotSpring { get; set; }
	public int TemporaryStatus_HotSpring_Time { get; set; }
	public int TemporaryStatus_HotSpring_End_Time { get; set; }
	protected TimeManager.JustTimerData TemporaryStatus_HotSpring_Handle { get; set; }
	public VaccinationID TemporaryStatus_Vaccination { get; set; }
	public int TemporaryStatus_Vaccination_Time { get; set; }
	public int TemporaryStatus_Vaccination_End_Time { get; set; }
	protected TimeManager.JustTimerData TemporaryStatus_Vaccination_Handle { get; set; }
	public bool IsScore_ATKUp { get; }
	public int Score_ATKUp_End_Time { get; set; }
	protected TimeManager.JustTimerData Score_ATKUp_Handle { get; set; }
	public bool IsScore_DEFUp { get; }
	public int Score_DEFUp_End_Time { get; set; }
	protected TimeManager.JustTimerData Score_DEFUp_Handle { get; set; }
	public int Rp { get; set; }
	public float StunGage { get; set; }
	private float DecreaseStunGagePerSec { get; }
	private float PoisonTimer { get; set; }
	private float SickTimer { get; set; }
	private float StunTimer { get; set; }
	private float SleepTimer { get; set; }
	public bool IsKnockback { get; }
	public float CurrentKnockbackTimer { get; set; }
	public float BlowHealCoolTime { get; set; }
	public float CurrentBlowTimer { get; set; }
	protected abstract float PoisonDamagePercent { get; }
	public BadStatus CurrentBadStatus { get; set; }
	public bool IsInvisible { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A68F0 Offset: 0x1A69F1 VA: 0x1A68F0
	// RVA: 0x1E57100 Offset: 0x1E57201 VA: 0x1E57100
	public StatusDataBase get_StatusData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6900 Offset: 0x1A6A01 VA: 0x1A6900
	// RVA: 0x1E57110 Offset: 0x1E57211 VA: 0x1E57110
	protected void set_StatusData(StatusDataBase value) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract CharaParamDataTable GetCharaParam() { }

	// RVA: 0x1E57120 Offset: 0x1E57221 VA: 0x1E57120 Slot: 14
	protected virtual bool get_IsBoss() { }

	// RVA: 0x1E57130 Offset: 0x1E57231 VA: 0x1E57130 Slot: 10
	public override void Renew() { }

	// RVA: 0x1E57510 Offset: 0x1E57611 VA: 0x1E57510 Slot: 12
	public override ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon) { }

	// RVA: 0x1E58700 Offset: 0x1E58801 VA: 0x1E58700
	public int get_Level() { }

	// RVA: 0x1E58720 Offset: 0x1E58821 VA: 0x1E58720
	protected void set_Level(int value) { }

	// RVA: 0x1E58740 Offset: 0x1E58841 VA: 0x1E58740
	public int get_Exp() { }

	// RVA: 0x1E58760 Offset: 0x1E58861 VA: 0x1E58760
	public void set_Exp(int value) { }

	// RVA: 0x1E58780 Offset: 0x1E58881 VA: 0x1E58780
	public int GetNeedExp() { }

	// RVA: 0x1E587A0 Offset: 0x1E588A1 VA: 0x1E587A0 Slot: 8
	public override int get_Hp() { }

	// RVA: 0x1E587C0 Offset: 0x1E588C1 VA: 0x1E587C0 Slot: 9
	public override void set_Hp(int value) { }

	// RVA: 0x1E586A0 Offset: 0x1E587A1 VA: 0x1E586A0
	public ItemData get_TemporaryStatus_UseItem() { }

	// RVA: 0x1E587E0 Offset: 0x1E588E1 VA: 0x1E587E0
	protected void set_TemporaryStatus_UseItem(ItemData value) { }

	// RVA: 0x1E58800 Offset: 0x1E58901 VA: 0x1E58800
	public int get_TemporaryStatus_UseItem_Time() { }

	// RVA: 0x1E58820 Offset: 0x1E58921 VA: 0x1E58820
	protected void set_TemporaryStatus_UseItem_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6910 Offset: 0x1A6A11 VA: 0x1A6910
	// RVA: 0x1E58840 Offset: 0x1E58941 VA: 0x1E58840
	protected TimeManager.JustTimerData get_TemporaryStatus_UseItem_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6920 Offset: 0x1A6A21 VA: 0x1A6920
	// RVA: 0x1E58850 Offset: 0x1E58951 VA: 0x1E58850
	private void set_TemporaryStatus_UseItem_Handle(TimeManager.JustTimerData value) { }

	// RVA: 0x1E586E0 Offset: 0x1E587E1 VA: 0x1E586E0
	public HotSpringID get_TemporaryStatus_HotSpring() { }

	// RVA: 0x1E58860 Offset: 0x1E58961 VA: 0x1E58860
	protected void set_TemporaryStatus_HotSpring(HotSpringID value) { }

	// RVA: 0x1E58880 Offset: 0x1E58981 VA: 0x1E58880
	public int get_TemporaryStatus_HotSpring_Time() { }

	// RVA: 0x1E588A0 Offset: 0x1E589A1 VA: 0x1E588A0
	protected void set_TemporaryStatus_HotSpring_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6930 Offset: 0x1A6A31 VA: 0x1A6930
	// RVA: 0x1E588C0 Offset: 0x1E589C1 VA: 0x1E588C0
	public int get_TemporaryStatus_HotSpring_End_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6940 Offset: 0x1A6A41 VA: 0x1A6940
	// RVA: 0x1E588D0 Offset: 0x1E589D1 VA: 0x1E588D0
	protected void set_TemporaryStatus_HotSpring_End_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6950 Offset: 0x1A6A51 VA: 0x1A6950
	// RVA: 0x1E588E0 Offset: 0x1E589E1 VA: 0x1E588E0
	protected TimeManager.JustTimerData get_TemporaryStatus_HotSpring_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6960 Offset: 0x1A6A61 VA: 0x1A6960
	// RVA: 0x1E588F0 Offset: 0x1E589F1 VA: 0x1E588F0
	private void set_TemporaryStatus_HotSpring_Handle(TimeManager.JustTimerData value) { }

	// RVA: 0x1E586C0 Offset: 0x1E587C1 VA: 0x1E586C0
	public VaccinationID get_TemporaryStatus_Vaccination() { }

	// RVA: 0x1E58900 Offset: 0x1E58A01 VA: 0x1E58900
	protected void set_TemporaryStatus_Vaccination(VaccinationID value) { }

	// RVA: 0x1E58920 Offset: 0x1E58A21 VA: 0x1E58920
	public int get_TemporaryStatus_Vaccination_Time() { }

	// RVA: 0x1E58940 Offset: 0x1E58A41 VA: 0x1E58940
	protected void set_TemporaryStatus_Vaccination_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6970 Offset: 0x1A6A71 VA: 0x1A6970
	// RVA: 0x1E58960 Offset: 0x1E58A61 VA: 0x1E58960
	public int get_TemporaryStatus_Vaccination_End_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6980 Offset: 0x1A6A81 VA: 0x1A6980
	// RVA: 0x1E58970 Offset: 0x1E58A71 VA: 0x1E58970
	protected void set_TemporaryStatus_Vaccination_End_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6990 Offset: 0x1A6A91 VA: 0x1A6990
	// RVA: 0x1E58980 Offset: 0x1E58A81 VA: 0x1E58980
	protected TimeManager.JustTimerData get_TemporaryStatus_Vaccination_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69A0 Offset: 0x1A6AA1 VA: 0x1A69A0
	// RVA: 0x1E58990 Offset: 0x1E58A91 VA: 0x1E58990
	private void set_TemporaryStatus_Vaccination_Handle(TimeManager.JustTimerData value) { }

	// RVA: 0x1E589A0 Offset: 0x1E58AA1 VA: 0x1E589A0
	public bool get_IsScore_ATKUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69B0 Offset: 0x1A6AB1 VA: 0x1A69B0
	// RVA: 0x1E589D0 Offset: 0x1E58AD1 VA: 0x1E589D0
	public int get_Score_ATKUp_End_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69C0 Offset: 0x1A6AC1 VA: 0x1A69C0
	// RVA: 0x1E589E0 Offset: 0x1E58AE1 VA: 0x1E589E0
	protected void set_Score_ATKUp_End_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69D0 Offset: 0x1A6AD1 VA: 0x1A69D0
	// RVA: 0x1E589F0 Offset: 0x1E58AF1 VA: 0x1E589F0
	protected TimeManager.JustTimerData get_Score_ATKUp_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69E0 Offset: 0x1A6AE1 VA: 0x1A69E0
	// RVA: 0x1E58A00 Offset: 0x1E58B01 VA: 0x1E58A00
	private void set_Score_ATKUp_Handle(TimeManager.JustTimerData value) { }

	// RVA: 0x1E58A10 Offset: 0x1E58B11 VA: 0x1E58A10
	public bool get_IsScore_DEFUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A69F0 Offset: 0x1A6AF1 VA: 0x1A69F0
	// RVA: 0x1E58A40 Offset: 0x1E58B41 VA: 0x1E58A40
	public int get_Score_DEFUp_End_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A00 Offset: 0x1A6B01 VA: 0x1A6A00
	// RVA: 0x1E58A50 Offset: 0x1E58B51 VA: 0x1E58A50
	protected void set_Score_DEFUp_End_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A10 Offset: 0x1A6B11 VA: 0x1A6A10
	// RVA: 0x1E58A60 Offset: 0x1E58B61 VA: 0x1E58A60
	protected TimeManager.JustTimerData get_Score_DEFUp_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A20 Offset: 0x1A6B21 VA: 0x1A6A20
	// RVA: 0x1E58A70 Offset: 0x1E58B71 VA: 0x1E58A70
	private void set_Score_DEFUp_Handle(TimeManager.JustTimerData value) { }

	// RVA: 0x1E57440 Offset: 0x1E57541 VA: 0x1E57440
	public int get_Rp() { }

	// RVA: 0x1E57460 Offset: 0x1E57561 VA: 0x1E57460
	public void set_Rp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A30 Offset: 0x1A6B31 VA: 0x1A6A30
	// RVA: 0x1E58A80 Offset: 0x1E58B81 VA: 0x1E58A80
	public float get_StunGage() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A40 Offset: 0x1A6B41 VA: 0x1A6A40
	// RVA: 0x1E58A90 Offset: 0x1E58B91 VA: 0x1E58A90
	protected void set_StunGage(float value) { }

	// RVA: 0x1E58AA0 Offset: 0x1E58BA1 VA: 0x1E58AA0
	private float get_DecreaseStunGagePerSec() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A50 Offset: 0x1A6B51 VA: 0x1A6A50
	// RVA: 0x1E58AB0 Offset: 0x1E58BB1 VA: 0x1E58AB0
	private float get_PoisonTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A60 Offset: 0x1A6B61 VA: 0x1A6A60
	// RVA: 0x1E58AC0 Offset: 0x1E58BC1 VA: 0x1E58AC0
	private void set_PoisonTimer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A70 Offset: 0x1A6B71 VA: 0x1A6A70
	// RVA: 0x1E58AD0 Offset: 0x1E58BD1 VA: 0x1E58AD0
	private float get_SickTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A80 Offset: 0x1A6B81 VA: 0x1A6A80
	// RVA: 0x1E58AE0 Offset: 0x1E58BE1 VA: 0x1E58AE0
	private void set_SickTimer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6A90 Offset: 0x1A6B91 VA: 0x1A6A90
	// RVA: 0x1E58AF0 Offset: 0x1E58BF1 VA: 0x1E58AF0
	private float get_StunTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AA0 Offset: 0x1A6BA1 VA: 0x1A6AA0
	// RVA: 0x1E58B00 Offset: 0x1E58C01 VA: 0x1E58B00
	private void set_StunTimer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AB0 Offset: 0x1A6BB1 VA: 0x1A6AB0
	// RVA: 0x1E58B10 Offset: 0x1E58C11 VA: 0x1E58B10
	private float get_SleepTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AC0 Offset: 0x1A6BC1 VA: 0x1A6AC0
	// RVA: 0x1E58B20 Offset: 0x1E58C21 VA: 0x1E58B20
	private void set_SleepTimer(float value) { }

	// RVA: 0x1E58B30 Offset: 0x1E58C31 VA: 0x1E58B30
	public bool get_IsKnockback() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AD0 Offset: 0x1A6BD1 VA: 0x1A6AD0
	// RVA: 0x1E58B40 Offset: 0x1E58C41 VA: 0x1E58B40
	public float get_CurrentKnockbackTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AE0 Offset: 0x1A6BE1 VA: 0x1A6AE0
	// RVA: 0x1E58B50 Offset: 0x1E58C51 VA: 0x1E58B50
	private void set_CurrentKnockbackTimer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6AF0 Offset: 0x1A6BF1 VA: 0x1A6AF0
	// RVA: 0x1E58B60 Offset: 0x1E58C61 VA: 0x1E58B60
	public float get_BlowHealCoolTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B00 Offset: 0x1A6C01 VA: 0x1A6B00
	// RVA: 0x1E58B70 Offset: 0x1E58C71 VA: 0x1E58B70
	private void set_BlowHealCoolTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B10 Offset: 0x1A6C11 VA: 0x1A6B10
	// RVA: 0x1E58B80 Offset: 0x1E58C81 VA: 0x1E58B80
	public float get_CurrentBlowTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B20 Offset: 0x1A6C21 VA: 0x1A6B20
	// RVA: 0x1E58B90 Offset: 0x1E58C91 VA: 0x1E58B90
	private void set_CurrentBlowTimer(float value) { }

	// RVA: 0x1E58BA0 Offset: 0x1E58CA1 VA: 0x1E58BA0
	public void ClearBlowTimer() { }

	// RVA: 0x1E58BB0 Offset: 0x1E58CB1 VA: 0x1E58BB0 Slot: 15
	public virtual void UpdateStatus() { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract float get_PoisonDamagePercent() { }

	// RVA: 0x1E59350 Offset: 0x1E59451 VA: 0x1E59350
	private void InvokePoisonDamage() { }

	// RVA: 0x1E59A50 Offset: 0x1E59B51 VA: 0x1E59A50
	private void InvokeSickDamage() { }

	// RVA: 0x1E5A3D0 Offset: 0x1E5A4D1 VA: 0x1E5A3D0
	public DamageInfo CreateDamageInfo(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float attackStun, AttackAttribute attackAttribute) { }

	// RVA: 0x1E5A4B0 Offset: 0x1E5A5B1 VA: 0x1E5A4B0
	public DamageInfo CreateDamageInfoHitSystem(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float stunRate, AttackAttribute attackAttribute) { }

	// RVA: 0x1E5A600 Offset: 0x1E5A701 VA: 0x1E5A600 Slot: 17
	public virtual DamageInfo CreateDamageInfo(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float attackStun, AttackAttribute attackAttribute, Vector3 hitPosition) { }

	// RVA: 0x1E5AC10 Offset: 0x1E5AD11 VA: 0x1E5AC10 Slot: 18
	public virtual DamageInfo CreateMagicDamageInfo(MagicParamID paramID, int level) { }

	// RVA: 0x1E5ACA0 Offset: 0x1E5ADA1 VA: 0x1E5ACA0 Slot: 19
	public virtual DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level) { }

	// RVA: 0x1E5ACD0 Offset: 0x1E5ADD1 VA: 0x1E5ACD0 Slot: 11
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1E5B980 Offset: 0x1E5BA81 VA: 0x1E5B980
	protected void ReTimerTemporaryStatus() { }

	// RVA: 0x1E5BA40 Offset: 0x1E5BB41 VA: 0x1E5BA40
	private void SetTemporaryStatus_UseItem(ItemData itemData, bool reTimer = False) { }

	// RVA: 0x1E5BC00 Offset: 0x1E5BD01 VA: 0x1E5BC00
	public void SetTemporaryStatus_HotSpring(HotSpringID hotSpringID, bool reTimer = False) { }

	// RVA: 0x1E5BDA0 Offset: 0x1E5BEA1 VA: 0x1E5BDA0
	public void SetTemporaryStatus_Vaccination(VaccinationID id, bool reTimer = False) { }

	// RVA: 0x1E5BFA0 Offset: 0x1E5C0A1 VA: 0x1E5BFA0
	public bool SetScore_ATKUp(int level, bool reTimer = False) { }

	// RVA: 0x1E5C110 Offset: 0x1E5C211 VA: 0x1E5C110
	public bool SetScore_DEFUp(int level, bool reTimer = False) { }

	// RVA: 0x1E58F00 Offset: 0x1E59001 VA: 0x1E58F00
	public void Heal(int healHp, bool hpPercent, int healRp, bool rpPercent, BadStatus badStatus = 0, bool isDisplay = True) { }

	// RVA: 0x1E5C280 Offset: 0x1E5C381 VA: 0x1E5C280
	public void FullHeal(bool isDisplay = False) { }

	// RVA: 0x1E59F90 Offset: 0x1E5A091 VA: 0x1E59F90
	public void ReduceRp(int value, bool isDamage, bool display, bool IgnoreGamePause = False) { }

	// RVA: 0x1E5C2A0 Offset: 0x1E5C3A1 VA: 0x1E5C2A0
	public int AddExpWithCheckLevelup(int addExp, MonsterDataID monsterDataID = 0) { }

	// RVA: 0x1E5C970 Offset: 0x1E5CA71 VA: 0x1E5C970
	private void PlayLevelUpEffect() { }

	// RVA: 0x1E5C630 Offset: 0x1E5C731 VA: 0x1E5C630
	public void LevelChangeSet(int value) { }

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void LevelUp() { }

	// RVA: 0x1E5CB80 Offset: 0x1E5CC81 VA: 0x1E5CB80 Slot: 21
	protected virtual void LevelDown() { }

	// RVA: 0x1E57480 Offset: 0x1E57581 VA: 0x1E57480
	public void updateHPRP(int setHp, int setRp) { }

	// RVA: 0x1E59330 Offset: 0x1E59431 VA: 0x1E59330
	public BadStatus get_CurrentBadStatus() { }

	// RVA: 0x1E5CC10 Offset: 0x1E5CD11 VA: 0x1E5CC10
	private void set_CurrentBadStatus(BadStatus value) { }

	// RVA: 0x1E59B20 Offset: 0x1E59C21 VA: 0x1E59B20
	public void SetBadStatus(BadStatus badStatus, bool isEnable) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B30 Offset: 0x1A6C31 VA: 0x1A6B30
	// RVA: 0x1E5CC30 Offset: 0x1E5CD31 VA: 0x1E5CC30
	public bool get_IsInvisible() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B40 Offset: 0x1A6C41 VA: 0x1A6B40
	// RVA: 0x1E5CC40 Offset: 0x1E5CD41 VA: 0x1E5CC40
	private void set_IsInvisible(bool value) { }

	// RVA: 0x1E4CBC0 Offset: 0x1E4CCC1 VA: 0x1E4CBC0
	public void SetInvisible(bool isInvisible) { }

	// RVA: 0x1E5CC50 Offset: 0x1E5CD51 VA: 0x1E5CC50
	public bool UseItem(ItemData itemData, int addLove = 0) { }

	// RVA: 0x1E5D490 Offset: 0x1E5D591 VA: 0x1E5D490
	private void DispUseParamText(ref UseParameter useParameter, int healHp, int healRp) { }

	// RVA: 0x1E5D3F0 Offset: 0x1E5D4F1 VA: 0x1E5D3F0
	private void AddPersistentParameter(Parameter parameter) { }

	// RVA: 0x1E5D9A0 Offset: 0x1E5DAA1 VA: 0x1E5D9A0
	public void CancelJustTimeHandler() { }

	// RVA: 0x1E5DB20 Offset: 0x1E5DC21 VA: 0x1E5DB20
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B50 Offset: 0x1A6C51 VA: 0x1A6B50
	// RVA: 0x1E5DC30 Offset: 0x1E5DD31 VA: 0x1E5DC30
	private void <SetTemporaryStatus_UseItem>b__139_0(TimeManager.JustTimerData timerData) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B60 Offset: 0x1A6C61 VA: 0x1A6B60
	// RVA: 0x1E5DC90 Offset: 0x1E5DD91 VA: 0x1E5DC90
	private void <SetTemporaryStatus_HotSpring>b__140_0(TimeManager.JustTimerData timerData) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B70 Offset: 0x1A6C71 VA: 0x1A6B70
	// RVA: 0x1E5DCF0 Offset: 0x1E5DDF1 VA: 0x1E5DCF0
	private void <SetTemporaryStatus_Vaccination>b__141_0(TimeManager.JustTimerData timerData) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B80 Offset: 0x1A6C81 VA: 0x1A6B80
	// RVA: 0x1E5DD50 Offset: 0x1E5DE51 VA: 0x1E5DD50
	private void <SetScore_ATKUp>b__142_0(TimeManager.JustTimerData timerData) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6B90 Offset: 0x1A6C91 VA: 0x1A6B90
	// RVA: 0x1E5DDA0 Offset: 0x1E5DEA1 VA: 0x1E5DDA0
	private void <SetScore_DEFUp>b__143_0(TimeManager.JustTimerData timerData) { }
}

