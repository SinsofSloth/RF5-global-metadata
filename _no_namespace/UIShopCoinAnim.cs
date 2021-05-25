public class UIShopCoinAnim : MonoBehaviour // TypeDefIndex: 8832
{
	// Fields
	[SerializeField] // RVA: 0x173EA0 Offset: 0x173FA1 VA: 0x173EA0
	public RectTransform TargetPoint; // 0x18
	private Vector2 StartPos; // 0x20
	private Vector2 StartSize; // 0x28
	private Image Image; // 0x30
	[SerializeField] // RVA: 0x173EB0 Offset: 0x173FB1 VA: 0x173EB0
	public Sprite[] RandSprites; // 0x38
	[SerializeField] // RVA: 0x173EC0 Offset: 0x173FC1 VA: 0x173EC0
	public float MovTimeMax; // 0x40
	private float MovTime; // 0x44
	[SerializeField] // RVA: 0x173ED0 Offset: 0x173FD1 VA: 0x173ED0
	public AnimationCurve AddXCurve; // 0x48
	[SerializeField] // RVA: 0x173EE0 Offset: 0x173FE1 VA: 0x173EE0
	public AnimationCurve AddYCurve; // 0x50
	[SerializeField] // RVA: 0x173EF0 Offset: 0x173FF1 VA: 0x173EF0
	public Vector2 AddRange; // 0x58
	[SerializeField] // RVA: 0x173F00 Offset: 0x174001 VA: 0x173F00
	public int LastCoinMax; // 0x60
	[SerializeField] // RVA: 0x173F10 Offset: 0x174011 VA: 0x173F10
	public int LastCoinMin; // 0x64
	[SerializeField] // RVA: 0x173F20 Offset: 0x174021 VA: 0x173F20
	public AnimationCurve CurveRotateCoin; // 0x68
	private float RotateTime; // 0x70
	[SerializeField] // RVA: 0x173F30 Offset: 0x174031 VA: 0x173F30
	public float rotateScale; // 0x74
	[SerializeField] // RVA: 0x173F40 Offset: 0x174041 VA: 0x173F40
	public UIShopMoneyEffect UIShopMoneyEffect; // 0x78
	[SerializeField] // RVA: 0x173F50 Offset: 0x174051 VA: 0x173F50
	public UIShopMoneyEffect UIShopMoneyEffect2; // 0x80
	[SerializeField] // RVA: 0x173F60 Offset: 0x174061 VA: 0x173F60
	[RangeAttribute] // RVA: 0x173F60 Offset: 0x174061 VA: 0x173F60
	public float EffectRate; // 0x88

	// Methods

	// RVA: 0x1DDD9F0 Offset: 0x1DDDAF1 VA: 0x1DDD9F0
	public UIShopCoinAnim CloneUse(Vector2 addPos) { }

	// RVA: 0x1DDDBA0 Offset: 0x1DDDCA1 VA: 0x1DDDBA0
	private void SetCloneInit(UIShopCoinAnim originalObj) { }

	// RVA: 0x1DDDDA0 Offset: 0x1DDDEA1 VA: 0x1DDDDA0
	private void Update() { }

	// RVA: 0x1DDE170 Offset: 0x1DDE271 VA: 0x1DDE170
	private void OnDestroy() { }

	// RVA: 0x1DDE230 Offset: 0x1DDE331 VA: 0x1DDE230
	public void .ctor() { }
}

