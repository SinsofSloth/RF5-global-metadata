public class AdvCharaShake : AdvCharaAnim // TypeDefIndex: 8442
{
	// Fields
	[SerializeField] // RVA: 0x16F920 Offset: 0x16FA21 VA: 0x16F920
	private Vector2 MoveRange; // 0x1C
	private Vector2 NowPos; // 0x24
	private Vector2 NextPos; // 0x2C
	[SerializeField] // RVA: 0x16F930 Offset: 0x16FA31 VA: 0x16F930
	private float TimeMax; // 0x34
	private float playTime; // 0x38
	[SerializeField] // RVA: 0x16F940 Offset: 0x16FA41 VA: 0x16F940
	private int ShakeCountMax; // 0x3C
	private int ShakeCount; // 0x40
	[SerializeField] // RVA: 0x16F950 Offset: 0x16FA51 VA: 0x16F950
	private bool ResetPosOnEnd; // 0x44
	[SerializeField] // RVA: 0x16F960 Offset: 0x16FA61 VA: 0x16F960
	private bool ResetPosOnStart; // 0x45
	private Vector2 StartPos; // 0x48
	private RectTransform RectTransform; // 0x50

	// Methods

	// RVA: 0x1BF9350 Offset: 0x1BF9451 VA: 0x1BF9350 Slot: 4
	public override void PlayAnim() { }

	// RVA: 0x1BF94B0 Offset: 0x1BF95B1 VA: 0x1BF94B0 Slot: 5
	public override void EndAnim() { }

	// RVA: 0x1BF9530 Offset: 0x1BF9631 VA: 0x1BF9530
	private void Update() { }

	// RVA: 0x1BF9700 Offset: 0x1BF9801 VA: 0x1BF9700
	public void .ctor() { }
}

