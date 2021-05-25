[CreateAssetMenuAttribute] // RVA: 0x146000 Offset: 0x146101 VA: 0x146000
public class CharacterMoveSetting : ScriptableObject // TypeDefIndex: 6930
{
	// Fields
	[HeaderAttribute] // RVA: 0x1615C0 Offset: 0x1616C1 VA: 0x1615C0
	[SerializeField] // RVA: 0x1615C0 Offset: 0x1616C1 VA: 0x1615C0
	public LayerMask GroundLayer; // 0x18
	[SerializeField] // RVA: 0x161610 Offset: 0x161711 VA: 0x161610
	public AnimationCurve AccelerationCurve; // 0x20
	[SerializeField] // RVA: 0x161620 Offset: 0x161721 VA: 0x161620
	public AnimationCurve RotateSpeedCurve; // 0x28
	[SerializeField] // RVA: 0x161630 Offset: 0x161731 VA: 0x161630
	public float SlopeMax; // 0x30
	[SerializeField] // RVA: 0x161640 Offset: 0x161741 VA: 0x161640
	public float SlopeMin; // 0x34
	[SerializeField] // RVA: 0x161650 Offset: 0x161751 VA: 0x161650
	public float SlopeDef; // 0x38
	[SerializeField] // RVA: 0x161660 Offset: 0x161761 VA: 0x161660
	public float SlopeTimeLimit; // 0x3C
	[SerializeField] // RVA: 0x161670 Offset: 0x161771 VA: 0x161670
	public AnimationCurve SlopeRate; // 0x40
	[SerializeField] // RVA: 0x161680 Offset: 0x161781 VA: 0x161680
	public float StepMax; // 0x48
	[SerializeField] // RVA: 0x161690 Offset: 0x161791 VA: 0x161690
	public float AvoidancePower; // 0x4C
	[SerializeField] // RVA: 0x1616A0 Offset: 0x1617A1 VA: 0x1616A0
	public AnimationCurve AvoidanceDecelRate; // 0x50
	[HeaderAttribute] // RVA: 0x1616B0 Offset: 0x1617B1 VA: 0x1616B0
	[SerializeField] // RVA: 0x1616B0 Offset: 0x1617B1 VA: 0x1616B0
	public AnimationCurve KnockbackPower; // 0x58
	[SerializeField] // RVA: 0x161700 Offset: 0x161801 VA: 0x161700
	public AnimationCurve KnockbackDuration; // 0x60
	[HeaderAttribute] // RVA: 0x161710 Offset: 0x161811 VA: 0x161710
	[SerializeField] // RVA: 0x161710 Offset: 0x161811 VA: 0x161710
	public AnimationCurve LaunchPower; // 0x68

	// Methods

	// RVA: 0x1E4FBA0 Offset: 0x1E4FCA1 VA: 0x1E4FBA0
	public void .ctor() { }
}

