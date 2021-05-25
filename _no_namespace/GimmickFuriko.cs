public class GimmickFuriko : GimmickBase // TypeDefIndex: 7574
{
	// Fields
	[SerializeField] // RVA: 0x1676C0 Offset: 0x1677C1 VA: 0x1676C0
	private float Interval; // 0x20
	[SerializeField] // RVA: 0x1676D0 Offset: 0x1677D1 VA: 0x1676D0
	[RangeAttribute] // RVA: 0x1676D0 Offset: 0x1677D1 VA: 0x1676D0
	private float MaxAngle; // 0x24
	[SerializeField] // RVA: 0x167720 Offset: 0x167821 VA: 0x167720
	private bool InitialDirection; // 0x28
	[SerializeField] // RVA: 0x167730 Offset: 0x167831 VA: 0x167730
	[RangeAttribute] // RVA: 0x167730 Offset: 0x167831 VA: 0x167730
	private float InitialAlpha; // 0x2C
	[SerializeField] // RVA: 0x167770 Offset: 0x167871 VA: 0x167770
	private float Damage; // 0x30
	[SerializeField] // RVA: 0x167780 Offset: 0x167881 VA: 0x167780
	[RangeAttribute] // RVA: 0x167780 Offset: 0x167881 VA: 0x167780
	private float KnockBackPower; // 0x34
	[SerializeField] // RVA: 0x1677C0 Offset: 0x1678C1 VA: 0x1677C0
	private AnimationCurve AnimationCurve; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1677D0 Offset: 0x1678D1 VA: 0x1677D0
	private bool <Direction>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1677E0 Offset: 0x1678E1 VA: 0x1677E0
	private float <ElapsedTime>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x1677F0 Offset: 0x1678F1 VA: 0x1677F0
	private float <PrevT>k__BackingField; // 0x48
	private Transform Model; // 0x50
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x58
	private Collider HitCollition; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x167800 Offset: 0x167901 VA: 0x167800
	private Vector3 <Velocity>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x167810 Offset: 0x167911 VA: 0x167810
	private Vector3 <PrevPos>k__BackingField; // 0x74

	// Properties
	private bool Direction { get; set; }
	private float ElapsedTime { get; set; }
	private float PrevT { get; set; }
	private Vector3 Velocity { get; set; }
	private Vector3 PrevPos { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A1C20 Offset: 0x1A1D21 VA: 0x1A1C20
	// RVA: 0x1EA0AC0 Offset: 0x1EA0BC1 VA: 0x1EA0AC0
	private bool get_Direction() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C30 Offset: 0x1A1D31 VA: 0x1A1C30
	// RVA: 0x1EA0AD0 Offset: 0x1EA0BD1 VA: 0x1EA0AD0
	private void set_Direction(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C40 Offset: 0x1A1D41 VA: 0x1A1C40
	// RVA: 0x1EA0AE0 Offset: 0x1EA0BE1 VA: 0x1EA0AE0
	private float get_ElapsedTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C50 Offset: 0x1A1D51 VA: 0x1A1C50
	// RVA: 0x1EA0AF0 Offset: 0x1EA0BF1 VA: 0x1EA0AF0
	private void set_ElapsedTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C60 Offset: 0x1A1D61 VA: 0x1A1C60
	// RVA: 0x1EA0B00 Offset: 0x1EA0C01 VA: 0x1EA0B00
	private float get_PrevT() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C70 Offset: 0x1A1D71 VA: 0x1A1C70
	// RVA: 0x1EA0B10 Offset: 0x1EA0C11 VA: 0x1EA0B10
	private void set_PrevT(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C80 Offset: 0x1A1D81 VA: 0x1A1C80
	// RVA: 0x1EA0B20 Offset: 0x1EA0C21 VA: 0x1EA0B20
	private Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C90 Offset: 0x1A1D91 VA: 0x1A1C90
	// RVA: 0x1EA0B30 Offset: 0x1EA0C31 VA: 0x1EA0B30
	private void set_Velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1CA0 Offset: 0x1A1DA1 VA: 0x1A1CA0
	// RVA: 0x1EA0B40 Offset: 0x1EA0C41 VA: 0x1EA0B40
	private Vector3 get_PrevPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1CB0 Offset: 0x1A1DB1 VA: 0x1A1CB0
	// RVA: 0x1EA0B50 Offset: 0x1EA0C51 VA: 0x1EA0B50
	private void set_PrevPos(Vector3 value) { }

	// RVA: 0x1EA0B60 Offset: 0x1EA0C61 VA: 0x1EA0B60 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA0D20 Offset: 0x1EA0E21 VA: 0x1EA0D20
	private void SetElapsedTimeAndUpdateRotate() { }

	// RVA: 0x1EA1000 Offset: 0x1EA1101 VA: 0x1EA1000
	private void FixedUpdate() { }

	// RVA: 0x1EA11E0 Offset: 0x1EA12E1 VA: 0x1EA11E0
	private void OnDrawGizmos() { }

	// RVA: 0x1EA1560 Offset: 0x1EA1661 VA: 0x1EA1560
	private void OnDamageEnter(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA19A0 Offset: 0x1EA1AA1 VA: 0x1EA19A0
	public void .ctor() { }
}

