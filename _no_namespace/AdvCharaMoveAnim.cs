public class AdvCharaMoveAnim : AdvCharaAnim // TypeDefIndex: 8441
{
	// Fields
	[SerializeField] // RVA: 0x16F8C0 Offset: 0x16F9C1 VA: 0x16F8C0
	private AnimationCurve PlayCurve; // 0x20
	[SerializeField] // RVA: 0x16F8D0 Offset: 0x16F9D1 VA: 0x16F8D0
	private float MoveRangeX; // 0x28
	[SerializeField] // RVA: 0x16F8E0 Offset: 0x16F9E1 VA: 0x16F8E0
	private float MoveRangeY; // 0x2C
	[SerializeField] // RVA: 0x16F8F0 Offset: 0x16F9F1 VA: 0x16F8F0
	private float TimeMax; // 0x30
	private float playTime; // 0x34
	[SerializeField] // RVA: 0x16F900 Offset: 0x16FA01 VA: 0x16F900
	private bool ResetPosOnEnd; // 0x38
	[SerializeField] // RVA: 0x16F910 Offset: 0x16FA11 VA: 0x16F910
	private bool ResetPosOnStart; // 0x39
	private Vector2 StartPos; // 0x3C
	private RectTransform RectTransform; // 0x48

	// Methods

	// RVA: 0x1BF90F0 Offset: 0x1BF91F1 VA: 0x1BF90F0 Slot: 4
	public override void PlayAnim() { }

	// RVA: 0x1BF91D0 Offset: 0x1BF92D1 VA: 0x1BF91D0 Slot: 5
	public override void EndAnim() { }

	// RVA: 0x1BF9240 Offset: 0x1BF9341 VA: 0x1BF9240
	private void Update() { }

	// RVA: 0x1BF9340 Offset: 0x1BF9441 VA: 0x1BF9340
	public void .ctor() { }
}

