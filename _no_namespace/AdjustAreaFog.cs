public class AdjustAreaFog : MonoBehaviour // TypeDefIndex: 7431
{
	// Fields
	[SerializeField] // RVA: 0x1666F0 Offset: 0x1667F1 VA: 0x1666F0
	private Color FogColor; // 0x18
	[SerializeField] // RVA: 0x166700 Offset: 0x166801 VA: 0x166700
	private float FogRate; // 0x28
	private float AdjustRatio; // 0x2C
	private bool IsAdjust; // 0x30
	private bool InArea; // 0x31
	private AreaFogAreaTrigger AreaFogAreaTrigger; // 0x38
	private AreaFogAdjustTrigger AreaFogAdjustTrigger; // 0x40

	// Methods

	// RVA: 0x1BF5300 Offset: 0x1BF5401 VA: 0x1BF5300
	private void Awake() { }

	// RVA: 0x1BF54A0 Offset: 0x1BF55A1 VA: 0x1BF54A0
	public void OnAreaEnter() { }

	// RVA: 0x1BF5550 Offset: 0x1BF5651 VA: 0x1BF5550
	public void OnAreaStay() { }

	// RVA: 0x1BF55F0 Offset: 0x1BF56F1 VA: 0x1BF55F0
	public void OnAreaExit() { }

	// RVA: 0x1BF5670 Offset: 0x1BF5771 VA: 0x1BF5670
	public void OnAdjustEnter() { }

	// RVA: 0x1BF5720 Offset: 0x1BF5821 VA: 0x1BF5720
	public void OnAdjustStay(float ratio) { }

	// RVA: 0x1BF57C0 Offset: 0x1BF58C1 VA: 0x1BF57C0
	public void OnAdjustExit() { }

	// RVA: 0x1BF5840 Offset: 0x1BF5941 VA: 0x1BF5840
	public void .ctor() { }
}

