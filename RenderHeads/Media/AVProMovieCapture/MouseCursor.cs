[AddComponentMenu] // RVA: 0x149030 Offset: 0x149131 VA: 0x149030
public class MouseCursor : MonoBehaviour // TypeDefIndex: 9601
{
	// Fields
	[SerializeField] // RVA: 0x17D320 Offset: 0x17D421 VA: 0x17D320
	private Texture2D _texture; // 0x18
	[SerializeField] // RVA: 0x17D330 Offset: 0x17D431 VA: 0x17D330
	private Vector2 _hotspotOffset; // 0x20
	[SerializeField] // RVA: 0x17D340 Offset: 0x17D441 VA: 0x17D340
	[RangeAttribute] // RVA: 0x17D340 Offset: 0x17D441 VA: 0x17D340
	private int _sizeScale; // 0x28
	[SerializeField] // RVA: 0x17D380 Offset: 0x17D481 VA: 0x17D380
	private int _depth; // 0x2C
	private GUIContent _content; // 0x30

	// Methods

	// RVA: 0x2327510 Offset: 0x2327611 VA: 0x2327510
	private void Start() { }

	// RVA: 0x2327520 Offset: 0x2327621 VA: 0x2327520
	public void SetTexture(Texture2D texture) { }

	// RVA: 0x23275F0 Offset: 0x23276F1 VA: 0x23275F0
	private void OnGUI() { }

	// RVA: 0x2327720 Offset: 0x2327821 VA: 0x2327720
	public void .ctor() { }
}

